namespace lvfucs.Helper
{
    public class Menu
    {
        private static string version = "vX.X.X";

        private static void PrintHeader()
        {
            int totalLength = version.Length + 16 + 12 + 12; // 12 spaces on each side, plus "LunaVPN fu " length and additional '#' characters
            string padding = new string('#', totalLength);

            Console.WriteLine(padding);
            Console.WriteLine($"#{new string(' ', 12)}LunaVPN fu {version} C#{new string(' ', 12)}#");
            Console.WriteLine(padding);
        }

        public static void PrintHelp()
        {
            PrintHeader();
            Console.WriteLine("Welcome to LunaVPN fu - Your Functioning Unit for LunaVPN needs!");
            Console.WriteLine("C# Edition");
            Console.WriteLine("Copyright © RePass Cloud Pty Ltd 2023\n");
            Console.WriteLine("Usage: LunaVPN_fu [-v] | [-h] | [-g <path_to_output.json>]\n");
            Console.WriteLine("  -v|--version                                Display version information");
            Console.WriteLine("  -qv                                         Display version number only");
            Console.WriteLine("  -h|--help                                   Display help");
            Console.WriteLine("  -gj|--generate-json <path_to_output.json>   Generate the JSON file");
            Console.WriteLine("  -gs|--generate-squid <path_to_output.json>  Generate the Squid Proxy credentials\n");
            Console.WriteLine("Usage: LunaVPN_fu [-u <URL> -h <HEADER> -d <path_to_input.json>]\n");
            Console.WriteLine("HTTP POST request");
            Console.WriteLine("  -u|--url <URL>                        Specify the URL for HTTP POST request");
            Console.WriteLine("  -h|--header <HEADER>                  Specify the header for HTTP POST request");
            Console.WriteLine("  -d|--data-file <path_to_input.json>   Specify the data file for HTTP POST request\n");
        }

        public static void PrintVersion()
        {
            PrintHeader();
            Console.WriteLine("Welcome to LunaVPN fu - Your Functioning Unit for networking needs!");
            Console.WriteLine("C# Edition");
            Console.WriteLine("Copyright © RePass Cloud Pty Ltd 2023\n");
        }

        public static void PrintVersionSmall()
        {
            Console.WriteLine(version.Replace("v",""));
        }
    }
}

