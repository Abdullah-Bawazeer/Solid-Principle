
namespace SRPLoggingService
{
    internal class Program
    {
        public class LoggingService
        {
            public enum enLoggingType { ToFile, ToEventLog, ToDatabase }

            public void Log(string message, enLoggingType enLoggingType)
            {
                if (enLoggingType == enLoggingType.ToEventLog)
                {
                    LogToEventLog(message);
                }
                else if (enLoggingType == enLoggingType.ToFile)
                {
                    logToFile(message);
                }

                else if (enLoggingType == enLoggingType.ToDatabase)
                {
                    LogToDatabase(message);
                }
            }

            private void LogToDatabase(string message)
            {
                Console.WriteLine($"Database   : {message}");
            }

            private void logToFile(string message)
            {
                Console.WriteLine($"ToFile     : {message}");
            }

            private void LogToEventLog(string message)
            {
                Console.WriteLine($"ToEventLog : {message}");
            }
        }
        static void Main(string[] args)
        {
            LoggingService loggingService = new LoggingService();
            loggingService.Log("Error Occured when sen data",LoggingService.enLoggingType.ToEventLog);
            loggingService.Log("Error Occured when sen data",LoggingService.enLoggingType.ToFile);
            loggingService.Log("Error Occured when sen data",LoggingService.enLoggingType.ToDatabase);
            Console.ReadKey();
        }
    }
}
