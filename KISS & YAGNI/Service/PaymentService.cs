
using KISS___YAGNI.commn;
using KISS___YAGNI.Models;

namespace KISS___YAGNI.Service
{
    public class PaymentService
    {
        public Recepit Pay(decimal amount ,string PaymentMethod)
        {
            if (string.Equals(PaymentMethod, PaymentConstant.Cash, StringComparison.OrdinalIgnoreCase))
            {
                var discout= PaymentConstant.CashDescount * amount;
                var finalAmount = amount - discout;
                return new Recepit(finalAmount , PaymentMethod);
            }
            if (string.Equals(PaymentMethod, PaymentConstant.Debit, StringComparison.OrdinalIgnoreCase))
            {
                var discout = PaymentConstant.DebitDescount * amount;
                var finalAmount = amount + discout;
                return new Recepit(finalAmount, PaymentMethod);
            }
            else
            {
                throw new ArgumentException(nameof(PaymentMethod));
            }
        }
    }
}
