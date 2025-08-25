using OCPLoggingService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_PaymentService
{
    public class PayPalPaymentProcessor : IPaymentProcessor
    {
        public void Process(string From, string To, int amount)
        {
            Console.WriteLine($"Usin Paypal opertaion from {From} to {To} Balance : {amount}");
        }
    }
}
