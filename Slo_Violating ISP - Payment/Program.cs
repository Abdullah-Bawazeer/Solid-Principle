namespace Slo_Violating_ISP___Payment
{
    public interface IPaypalPayment
    {
        void PaymentWithPaypal ();
    }

    public interface ICreditcardPayment
    {
        void PaymentWithCreditCard();
    }
    public interface IBitcoinPayment
    {
        void PaymentWithBitcoin();
    }

    public class PaypalPayment : IPaypalPayment
    {
        public void PaymentWithPaypal()
        {
            Console.WriteLine("Payment with Paypal");
        }
    }
    public class CreditCardPayment : ICreditcardPayment
    {
        public void PaymentWithCreditCard()
        {
            Console.WriteLine("Payment with CreditCard");
        }
    }

    public class BitcoinPayment : IBitcoinPayment
    {
        public void PaymentWithBitcoin()
        {
            Console.WriteLine("Payment with Bitcoin");
        }
    }
    public class AllPaymnet : IBitcoinPayment ,ICreditcardPayment,IPaypalPayment
    {
        public void PaymentWithBitcoin()
        {
            Console.WriteLine("Payment with Bitcoin");
        }
        public void PaymentWithCreditCard()
        {
            Console.WriteLine("Payment with CreditCard");
        }
        public void PaymentWithPaypal()
        {
            Console.WriteLine("Payment with Paypal");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PaypalPayment paypal = new PaypalPayment();
            paypal.PaymentWithPaypal();
            BitcoinPayment bitcoin = new BitcoinPayment();
            bitcoin.PaymentWithBitcoin();
            CreditCardPayment creditcard = new CreditCardPayment();
            creditcard.PaymentWithCreditCard();
            AllPaymnet allPaymnet = new AllPaymnet();
            allPaymnet.PaymentWithPaypal();
            allPaymnet.PaymentWithBitcoin();
            allPaymnet.PaymentWithCreditCard();
            Console.ReadKey();
        }
    }
}
