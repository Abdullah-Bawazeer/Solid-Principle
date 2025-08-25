namespace OTCNotificationService
{
    internal class Program
    {
        public class NotificationService
        {
            public INotification _notification { get; set; }
            public NotificationService(INotification notification)
            {
                _notification = notification;
            }
            public void SendNotifiction(string to, string message)
            {
               
                _notification.Send(to , message);
            }
        }
        public interface INotification
        {
            public void Send(string to , string message);
        }

        public class EmailSerive :INotification
        {
            public  void Send(string to, string message)
            {
                Console.WriteLine($"\nSend Email To {to} : {message}");
            }
        }

        public class SMSSerive :INotification
        {
            public void Send(string to, string message)
            {
                Console.WriteLine($"\nSend SMS To {to} : {message}");
            }
        }

        public class FaxSerive :INotification
        {
            public  void Send(string to, string message)
            {
                Console.WriteLine($"\nSend Fax To {to} : {message}");
            }
        }

        public class TelegramSerive :INotification
        {
            public  void Send(string to, string message)
            {
                Console.WriteLine($"\nSend Telegram To {to} : {message}");
            }
        }

        public class WhatsappSerive :INotification
        {
            public  void Send(string to, string message)
            {
                Console.WriteLine($"\nSend Whatsapp To {to} : {message}");
            }
        }
        public class SnappChatSerive : INotification
        {
            public void Send(string to, string message)
            {
                Console.WriteLine($"\nSnappChat Whatsapp To {to} : {message}");
            }
        }
        public class TiktokSerive : INotification
        {
            public void Send(string to, string message)
            {
                Console.WriteLine($"\nTiktok  To {to} : {message}");
            }
        }

        static void Main(string[] args)
        {
            NotificationService notificationService = new NotificationService(new EmailSerive());
            notificationService.SendNotifiction("abdullah bawazeer", "Email Massage");
            notificationService = new NotificationService(new SMSSerive());

            notificationService.SendNotifiction("abdullah bawazeer", "SMS Message ");
            notificationService = new NotificationService(new FaxSerive());
            notificationService.SendNotifiction("abdullah bawazeer", "Fax Message");
            notificationService = new NotificationService(new TelegramSerive());
            notificationService.SendNotifiction("abdullah bawazeer", "Telegram Message");
            notificationService = new NotificationService(new WhatsappSerive());
            notificationService.SendNotifiction("abdullah bawazeer", "Whatsapp Message");
            notificationService = new NotificationService(new SnappChatSerive());
            notificationService.SendNotifiction("abdullah bawazeer", "snappchat Message");
            notificationService = new NotificationService(new TiktokSerive());
            notificationService.SendNotifiction("abdullah bawazeer", "TiktokSerive Message");
            Console.ReadKey();
        }
    }
}
