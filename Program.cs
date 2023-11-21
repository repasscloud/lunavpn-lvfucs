using lvfucs.Core.Utilities;
using lvfucs.Core.Utilities.SquidProxy;
using lvfucs.Core.Utilities.Wireguard;
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
                    // Access the arguments with args[0], args[1], ..., args[5]
                    string? url = null;
                    string? header = null;
                    string? dataFile = null;

                    for (int i = 0; i < args.Length; i++)
                    {
                        switch (args[i].ToLower())
                        {
                            case "-u":
                            case "--url":
                                if (i + 1 < args.Length)
                                {
                                    url = args[i + 1];
                                    i++;
                                }
                                break;

                            case "-h":
                            case "--header":
                                if (i + 1 < args.Length)
                                {
                                    header = args[i + 1];
                                    i++;
                                }
                                break;

                            case "-d":
                            case "--data-file":
                                if (i + 1 < args.Length)
                                {
                                    dataFile = args[i + 1];
                                    i++;
                                }
                                break;
                            
                            default:
                                break;
                        }
                    }

                    // test all values pass null check
                    bool allVariablesNotNull = url != null && header != null && dataFile != null;

                    // test dataFile exists
                    // bool dataFileExists = File.Exists(dataFile);

                    // exit strategy
                    if (!allVariablesNotNull)
                    {
                        Logger.WriteLog(message: "At least one value is null", type: "Error");
                        Environment.Exit(1);
                    }

                    // Check if the path is a valid file path
                    bool isValidFilePath = Path.IsPathRooted(dataFile) && !string.IsNullOrEmpty(Path.GetFileName(dataFile));
                    // Check if the file has a .json extension
                    bool hasJsonExtension = Path.GetExtension(dataFile!).Equals(".json", StringComparison.OrdinalIgnoreCase);

                    // run the verification checks too
                    if (dataFile != null && isValidFilePath && hasJsonExtension)
                    {
                        // create the data.json file
                        await WgGen.PeerData(jsonFile: dataFile);
                    }
                    else
                    {
                        Logger.WriteLog(message: $"File {dataFile} is null, or isValidFilePath is {isValidFilePath}, or hasJsonExtension is {hasJsonExtension}", type: "Error");
                    }
                    break;

                default:
                    Logger.WriteLog(message: "Invalid number of arguments.", type: "Debug");
                    break;
            }
        }
    }
}

