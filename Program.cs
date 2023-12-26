using lvfucs.Core.V2.Utility;
using lvfucs.Helper;

namespace lvfucs
{
    class Program
    {
        static async Task Main(string[] args)
        {
            int numberOfArguments = args.Length;

            switch (numberOfArguments)
            {
                case 1:
                    switch (args[0].ToLower())
                    {
                        case "-h":
                        case "--help":
                            Menu.PrintHelp();
                            break;

                        case "-v":
                            Menu.PrintVersionSmall();
                            break;

                        case "--version":
                            Menu.PrintVersion();
                            break;

                        default:
                            Console.WriteLine("Incorrect parameters passed. Use '-h' for help.");
                            break;
                    }
                    break;

                case >= 2:

                    var options = CommandLineParser.ParseArguments(args);

                    if (!string.IsNullOrEmpty(options.SaveFile))
                    {
                        await JsonData2.GenerateJsonAsync(outPath: options.SaveFile.ToLower());
                    }

                    if (!string.IsNullOrEmpty(options.DataFile) && !string.IsNullOrEmpty(options.ApiEndpoint) && !string.IsNullOrEmpty(options.BearerToken))
                    {
                        await JsonData2.GenerateJsonPostAsync(outPath: options.DataFile.ToLower(), apiEndpoint: options.ApiEndpoint.ToLower(), bearerToken: options.BearerToken);
                    }
                    else
                    {
                        Logger.WriteLog(message: "Incorrect arguments provided, possibly?", type: "Debug");
                    }

                    break;

                default:
                    Logger.WriteLog(message: "Invalid number of arguments.", type: "Debug");
                    break;
            }
        }
    }
}

