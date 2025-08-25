
namespace slo_KISS___YAGNI.Service
{
    public class DebitPaymentStrategy : IPaymentStrategy
    {
        public Recepit Pay(decimal amount)
        {
            var discout = PaymentConstant.DebitDescount * amount;
            var finalAmount = amount + discout;
            return new Recepit(finalAmount, PaymentConstant.Debit);
        }
    }
}
