
namespace Example1InC__NotificationService_
{
    public class NotificationService
    {
        public enum enNotificationType { Email, SMS, Fax }

        public void SendNotification(string to, string message, enNotificationType enNotificationType)
        {
            if (enNotificationType == enNotificationType.Email)
            {
                SendEmail(to, message);
            }
            else if (enNotificationType == enNotificationType.SMS)
            {
                SendSMS(to, message);
            }
            else if (enNotificationType == enNotificationType.Fax)
            {
                SendFax(to, message);
            }

        }

        private void SendSMS(string to, string message)
        {
            Console.WriteLine($"\nSen SMS To {to} : {message}");
        }

        private void SendFax(string to, string message)
        {
            Console.WriteLine($"\nSen Fax To {to} : {message}");
        }

        private void SendEmail(string to, string message)
        {
            Console.WriteLine($"\nSen Email To {to} : {message}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationService notificationService = new NotificationService();
            notificationService.SendNotification("abdullah bawazeer","Email Massage" , NotificationService.enNotificationType.Email);
            notificationService.SendNotification("abdullah bawazeer","SMS Message " , NotificationService.enNotificationType.SMS);
            notificationService.SendNotification("abdullah bawazeer","Fax Message" , NotificationService.enNotificationType.Fax);
            Console.ReadKey();
        }
    }
}
