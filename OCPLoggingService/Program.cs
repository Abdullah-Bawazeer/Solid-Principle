namespace OCPLoggingService
{
    internal class Program
    {

        public class LoggingSerivec
        {
            private ILoggingService _loggingService;

            public LoggingSerivec(ILoggingService loggingService)
            {
                _loggingService = loggingService;
            }

            public void Log(string message)
            {
                _loggingService.Log(message);
            }
        }
        public interface ILoggingService
        {
            void Log(string message);
        }

        public class LogToFileSerivce : ILoggingService
        {
            public void Log(string message)
            {
                Console.WriteLine($"Log To File   :{message}");
            }
        }
        public class ToEvenetLogService : ILoggingService
        {
            public void Log(string message)
            {
                Console.WriteLine($"Log ToEventLog   :{message}");
            }
        }

        public class ToDatabaseLogService : ILoggingService
        {
            public void Log(string message)
            {
                Console.WriteLine($"Log To Databse   :{message}");
            }
        }

        public class LogToExternalFile : ILoggingService
        {
            public void Log(string message)
            {
                Console.WriteLine($"Log To External File   :{message}");
            }
        }
        static void Main(string[] args)
        {
            LoggingSerivec loggingSerivec = new LoggingSerivec(new LogToFileSerivce());
            loggingSerivec.Log("Error Occured when save Data");
             loggingSerivec = new LoggingSerivec(new ToEvenetLogService());
            loggingSerivec.Log("Error Occured when save Data");
            loggingSerivec = new LoggingSerivec(new ToDatabaseLogService());
            loggingSerivec.Log("Error Occured when save Data");
            loggingSerivec = new LoggingSerivec(new LogToExternalFile());
            loggingSerivec.Log("Error Occured when save Data");
            Console.ReadKey();
        }
    }
}
