
using slo_KISS___YAGNI.Service;

public class PaymentService
{
    private readonly IDictionary<string, IPaymentStrategy> _paymentStrategies;

    public PaymentService()
    {

        _paymentStrategies = new Dictionary<string, IPaymentStrategy>
        {
            {PaymentConstant.Cash , new CashPaymentStrategy() },
            {PaymentConstant.Debit , new DebitPaymentStrategy() },
        };
    }

    public Recepit Pay(decimal amount, string PaymentMethod)
    {
        if (_paymentStrategies.ContainsKey(PaymentMethod.ToUpper()))
        {

            return _paymentStrategies[PaymentMethod.ToUpper()].Pay(amount);
        }
        else
        {
            throw new ArgumentException(nameof(PaymentMethod));
        }

    }
}

