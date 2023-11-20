using lvfucs.Core.Utilities;
using lvfucs.Core.Utilities.SquidProxy;
using lvfucs.Helper;

namespace lvfucs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfArguments = args.Length;

            switch (numberOfArguments)
            {
                case 1:
                    //Console.WriteLine("One argument provided.");
                    switch (args[0].ToLower())
                    {
                        case "-h":
                        case "--help":
                            Menu.PrintHelp();
                            break;

                        case "-v":
                        case "--version":
                            Menu.PrintVersion();
                            break;

                        case "-qv":
                            Menu.PrintVersionSmall();
                            break;

                        default:
                            Console.WriteLine("Incorrect parameters passed. Use '-h' for help.");
                            break;
                    }
                    break;

                case 2:
                    //Console.WriteLine("Two arguments provided.");
                    // Access the arguments with args[0] and args[1]
                    switch (args[0].ToLower())
                    {
                        case "-gj":
                        case "--generate-json":
                            JsonData.GenerateJson(filePath: args[1].ToLower());
                            break;

                        case "-gs":
                        case "--generate-squid":
                            SquidGen.GenCredentials(outputDir: args[1].ToLower());
                            break;

                        default:
                            Console.WriteLine("Incorrect parameters passed. Use '-h' for help.");
                            break;
                    }
                    break;

                case 6:
                    Console.WriteLine("Six arguments provided.");
                    // Access the arguments with args[0], args[1], ..., args[5]
                    break;

                default:
                    Console.WriteLine("Invalid number of arguments.");
                    break;
            }
        }
    }
}

