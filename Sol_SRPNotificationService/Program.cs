namespace Sol_SRPNotificationService
{
    internal class Program
    {
        public class NotificationService
        {
            public enum eNotificartionType { SMS,Email,Fax}
            public void SendNotifiction(string to , string message , eNotificartionType eNotificartionType)
            {
                if (eNotificartionType == eNotificartionType.SMS)
                {
                    SMSSerive.SendSMS(to, message);
                }
                else if (eNotificartionType == eNotificartionType.Email)
                {
                    EmailSerive.SendEmail(to, message);
                }
                else if (eNotificartionType == eNotificartionType.Fax)
                {
                    FaxSerive.SendFax(to, message); 
                }
            }
        }

        public class EmailSerive
        {
            public static void SendEmail(string to , string message)
            {
                Console.WriteLine($"\nSen Email To {to} : {message}");
            }
        }

        public class SMSSerive
        {
            public static void SendSMS(string to, string message)
            {
                Console.WriteLine($"\nSen SMS To {to} : {message}");
            }
        }

        public class FaxSerive
        {
            public static void SendFax(string to, string message)
            {
                Console.WriteLine($"\nSen Fax To {to} : {message}");
            }
        }

        static void Main(string[] args)
        {
            NotificationService notificationService = new NotificationService();
            notificationService.SendNotifiction("abdullah bawazeer", "Email Massage", NotificationService.eNotificartionType.Email);
            notificationService.SendNotifiction("abdullah bawazeer", "SMS Message ", NotificationService.eNotificartionType.SMS);
            notificationService.SendNotifiction("abdullah bawazeer", "Fax Message", NotificationService.eNotificartionType.Fax);
            Console.ReadKey();
        }
    }
}
