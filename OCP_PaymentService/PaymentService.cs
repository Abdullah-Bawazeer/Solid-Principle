using OCPLoggingService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_PaymentService
{
    public class PaymentService
    {
        public IPaymentProcessor _paymentProcessor;

        public PaymentService(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        public void Payment(string From , string To , int amount)
        {
            _paymentProcessor.Process(From , To , amount);
        }
    }
}
