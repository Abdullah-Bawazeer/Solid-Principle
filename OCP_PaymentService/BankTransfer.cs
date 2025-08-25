using OCPLoggingService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_PaymentService
{
    public class BankTransferPaymentProcessor : IPaymentProcessor
    {
        public void Process(string From, string To, int amount)
        {
            Console.WriteLine($"Usin Bank Transfer  opertaion from {From} to {To} Balance : {amount}");
        }
    }
}
