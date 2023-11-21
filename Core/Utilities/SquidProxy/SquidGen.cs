using System.Diagnostics;
using lvfucs.Core.Utilities.Producer;
using lvfucs.Helper;

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
                    Logger.WriteLog(message: $"Unable to access/create {outputDir}, Error: {ex.Message}", type: "Debug");
                    Environment.Exit(1);
                }
            }

            // Generate Squid Proxy username and password
            string username = GenProd.GenerateUsername();
            string password = GenProd.GeneratePassword();

            // check usernamd and password is safe
            if (!GenProd.IsSafeInput(input: username) || !GenProd.IsSafeInput(input: password))
            {
                Logger.WriteLog(message: "Invalid input. Only alphanumeric characters are allowed", type: "Debug");
                Environment.Exit(1);
            }

            // set squid.creds path
            string squidCredsPath = Path.Combine(outputDir, "squid.creds");

            // set squid htpasswd
            string htpasswdPath = Path.Combine(outputDir, "passwd");

            // Construct the htpasswd command
            string command = $"-cb {htpasswdPath} {username} {password}";

            // Set up the process start info
            ProcessStartInfo psi = new ProcessStartInfo("/usr/bin/htpasswd", command);
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;

            // Start the process
            Process process = new Process();
            process.StartInfo = psi;
            process.Start();

            // Read the output and error streams
            // string output = process.StandardOutput.ReadToEnd();
            // string error = process.StandardError.ReadToEnd();

            // Wait for the process to exit
            process.WaitForExit();

            // Handle the output and error as needed
            // Console.WriteLine("Output: " + output);
            // Console.WriteLine("Error: " + error);

            // write to squidCredsPath
            try
            {
                // Write to the file without trailing newline
                using (StreamWriter outFile = new StreamWriter(squidCredsPath, false))
                {
                    outFile.Write($"{username}:{password}");
                }

                Logger.WriteLog(message: $"Credentials written to {squidCredsPath}", type: "Debug");
            }
            catch (Exception ex)
            {
                Logger.WriteLog(message: $"Error opening file for writing: {ex.Message}", type: "Debug");
            }
        }
    }
}

