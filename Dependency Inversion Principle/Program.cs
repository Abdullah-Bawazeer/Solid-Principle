using Dependency_Inversion_Principle.After;

namespace Dependency_Inversion_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var customers = Before.Repository.customers;
            //foreach (var customer in customers)
            //{
            //    var NotificationService = new Before.NotificatonService(customer );
            //    NotificationService.Notify();
            //}

            var customers = After.Repository.customers;
            
            foreach (var customer in customers)
            {
                var messageService = new List<IMessageService>
                {
                    new After.EmailService{EmailAddress=customer.EmailAddress},
                    new After.SMSService{MobileNo=customer.MobileNo},
                    new After.WhatsappService{number = "18291"}
                };
                // constarctor injection
                var notificationService= new After.NotificatonService(messageService);
                notificationService.Notify();

                /// property injection 
                var notificationService1 = new After.NotificatonService1();
                notificationService1.Service = messageService;
                notificationService1.Notify();

                
            }

            Console.ReadKey();
        }
    }
}
