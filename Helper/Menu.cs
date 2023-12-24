namespace lvfucs.Helper
{
    public class Menu
    {
        private static string version = "v2.1.1";

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
            Console.WriteLine("Welcome to LunaVPN fu - C# Edition");
            Console.WriteLine("Copyright © RePass Cloud Pty Ltd 2023\n");
            Console.WriteLine("Usage: LunaVPN_fu [-v] | [-h] | [-d <path_to_output.json>]\n");
            Console.WriteLine("  -v|--version                          Display version");
            Console.WriteLine("  -h|--help                             Display helop");
            Console.WriteLine("  -d|--data-file <path_to_output.json>  Generate the JSON file\n");
        }

        public static void PrintVersion()
        {
            PrintHeader();
            Console.WriteLine("Copyright © RePass Cloud Pty Ltd 2023\n");

        }

        public static void PrintVersionSmall()
        {
            Console.WriteLine($"{version}\n");
        }
    }
}

