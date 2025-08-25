namespace Slo_SRPLoggingService
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
                    EventLogService.Log(message);
                }
                else if (enLoggingType == enLoggingType.ToFile)
                {
                    FilLoggingService.log(message);
                }

                else if (enLoggingType == enLoggingType.ToDatabase)
                {
                    DatabaseLggingService.Log(message);
                }
            }
        }


        static void Main(string[] args)
        {
            LoggingService loggingService = new LoggingService();
            loggingService.Log("Error Occured when sen data", LoggingService.enLoggingType.ToEventLog);
            loggingService.Log("Error Occured when sen data", LoggingService.enLoggingType.ToFile);
            loggingService.Log("Error Occured when sen data", LoggingService.enLoggingType.ToDatabase);
            Console.ReadKey();
        }
    }
}
