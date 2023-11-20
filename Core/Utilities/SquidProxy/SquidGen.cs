using System.Diagnostics;
using lvfucs.Core.Utilities.Producer;

namespace lvfucs.Core.Utilities.SquidProxy
{
	public class SquidGen
	{
		public static void GenCredentials(string outputDir)
		{
			if (!Directory.Exists(outputDir))
			{
				try
				{
					Directory.CreateDirectory(outputDir);
				}
				catch (Exception ex)
				{
					Console.WriteLine($"Unable to access/create {outputDir}, Error: {ex.Message}");
					Environment.Exit(1);
				}
			}

			// Generate Squid Proxy username and password
			string username = GenProd.GenerateUsername();
			string password = GenProd.GeneratePassword();

			// check usernamd and password is safe
			if (!GenProd.IsSafeInput(input: username) || !GenProd.IsSafeInput(input: password))
			{
				Console.WriteLine("Invalid input. Only alphanumeric characters are allowed");
				Environment.Exit(1);
			}

			// set squid.creds path
			string squidCredsPath = Path.Combine(outputDir, "squid.conf");

			// set squid htpasswd
			string htpasswdPath = Path.Combine(outputDir, "htpasswd");

            // Construct the htpasswd command
            string command = $"/usr/bin/htpasswd -cb {htpasswdPath} {username} {password}";

            // Set up the process start info
            ProcessStartInfo psi = new ProcessStartInfo("sh", $"-c \"{command}\"");
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;

            // Start the process
            Process process = new Process();
            process.StartInfo = psi;
            process.Start();

            // Read the output and error streams
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            // Wait for the process to exit
            process.WaitForExit();

            // Handle the output and error as needed
            Console.WriteLine("Output: " + output);
            Console.WriteLine("Error: " + error);

            // write to squidCredsPath
            try
            {
                // Write to the file without trailing newline
                using (StreamWriter outFile = new StreamWriter(squidCredsPath, false))
                {
                    outFile.Write($"{username}:{password}");
                }

                Console.WriteLine($"Credentials written to {squidCredsPath}");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error opening file for writing: {ex.Message}");
            }
        }
	}
}

