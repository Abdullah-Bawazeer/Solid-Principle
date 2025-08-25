namespace Loose_Vs._Tight_Coupling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tight coupling 

            //NotificationService notificationService = new NotificationService(new EmailService() ,new SMSService());
            //notificationService.Notfy();


            // Loose coupling 

            NotificationService notificationService = new NotificationService(new EmailService());
            notificationService.Notfy();
            notificationService = new NotificationService(new SMSService());
            notificationService.Notfy();
            notificationService = new NotificationService(new whatsappService());
            notificationService.Notfy();
            Console.ReadKey();
        }
    }

    interface INotificationMode
    {
        void send();
    }
    class EmailService : INotificationMode
    {
        public void send()
        {
            Console.WriteLine("send email ...");
        }
    }
    class SMSService : INotificationMode
    {
        public void send()
        {
            Console.WriteLine("send SMS ...");
        }
    }

    class whatsappService : INotificationMode
    {
        public void send()
        {
            Console.WriteLine("whatsapp SMS ...");
        }
    }

    // Loose coupling 
    class NotificationService
    {
        private readonly INotificationMode _notificationMode;

        public NotificationService( INotificationMode notificationMode)
        {           
            this._notificationMode = notificationMode;
        }

        public void Notfy()
        {
            _notificationMode.send();
        }
    }



    // Tight coupling 
    //class NotificationService
    //{
    //    private readonly EmailService _emailService;
    //    private readonly SMSService sMSService;

    //    public NotificationService(EmailService emailService, SMSService sMSService)
    //    {
    //        _emailService = emailService;
    //        this.sMSService = sMSService;
    //    }

    //    public void Notfy()
    //    {
    //        _emailService.send();
    //        sMSService.send();
    //    }
    //}


}
