using log4net;
using log4net.Config;

namespace Service.DATA
{
    /// Класс для логгирования событий
    public class Logger
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Logger));

        public static ILog Log
        {
            get { return log; }
        }

        public static void InitLogger()
        {
            XmlConfigurator.Configure();
        }

        public enum LogLevel
        {
            Debug,
            Info,
            Warning,
            Error,
            Information
        }


        public static void WriteToFile(string message, string fileRepo, LogLevel logLevel)
        {
            string Path = @"C:\Logs";
            try
            {
                using (StreamWriter write = File.AppendText($@"{Path}\{fileRepo}\log{logLevel}_{DateTime.Now.ToString("yy-mm-dd")}.txt"))
                {
                    write.WriteLine($"{DateTime.Now.ToLongDateString()} | {logLevel} :: {message}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void WriteToFileDefault(string message, LogLevel logLevel)
        {
            string Path = @"C:\Logs";
            try
            {
                using (StreamWriter write = File.AppendText($@"{Path}\log{logLevel}_{DateTime.Now.ToString("yy-mm-dd")}.txt"))
                {
                    write.WriteLine($"{DateTime.Now.ToLongDateString()} | {logLevel} :: {message}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}