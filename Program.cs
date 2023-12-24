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

                case 2:
                    switch (args[0].ToLower())
                    {
                        case "-d":
                        case "--data-file":
                            await JsonData2.GenerateJsonAsync(outPath: args[1].ToLower(), apiEndpoint: args[2].ToLower(), bearerToken: args[3]);
                            break;

                        case "-s":
                        case "--save":
                            await JsonData2.GenerateJsonAsync(outPath: args[1].ToLower(), apiEndpoint: "x", bearerToken: "x");
                            break;
                    }
                    break;

                default:
                    Logger.WriteLog(message: "Invalid number of arguments.", type: "Debug");
                    break;
            }
        }
    }
}

