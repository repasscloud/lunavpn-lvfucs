namespace lvfucs.Helper
{
    public class Logger
    {
        public static void WriteLog(string message, string type)
        {
            string logFilePath = "/app/lunavpn/lunavpn.log";

            // create or append log to logfile
            using (StreamWriter sw = File.AppendText(logFilePath))
            {
                // write timestamped log to logfile
                sw.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{type}] {message}");
            }
        }
    }
}

