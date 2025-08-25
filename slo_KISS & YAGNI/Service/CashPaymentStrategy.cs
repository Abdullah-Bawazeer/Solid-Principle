
namespace slo_KISS___YAGNI.Service
{
    public class CashPaymentStrategy : IPaymentStrategy
    {
        public Recepit Pay(decimal amount)
        {
            var discout = PaymentConstant.CashDescount * amount;
            var finalAmount = amount - discout;
            return new Recepit(finalAmount, PaymentConstant.Cash);
        }
    }
}
