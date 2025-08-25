namespace OCP_PaymentService
{
    internal class Program
    {
                
        static void Main(string[] args)
        {
            PaymentService service = new PaymentService(new PayPalPaymentProcessor());
            service.Payment("abdullah", "Omer", 90000);
             service = new PaymentService(new CreditCardPaymentProcessor());
            service.Payment("abdullah", "Omer", 90000);
            service = new PaymentService(new BitcoinPaymentProcessor());
            service.Payment("abdullah", "Omer", 90000);
            service = new PaymentService(new BankTransferPaymentProcessor());
            service.Payment("abdullah", "Omer", 90000);
            Console.ReadKey();
        }
    }
}
