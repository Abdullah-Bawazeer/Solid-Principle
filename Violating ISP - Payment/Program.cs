namespace Violating_ISP___Payment
{
    public interface IPayment
    {
        void PaymenWithPaypal();
        void PaymenWithCreditCard();
        void PaymenWithBitcoin();
    }

    public class CreditCardPaymen : IPayment
    {
        public void PaymenWithBitcoin()
        {
            throw new NotImplementedException();
        }


        public void PaymenWithCreditCard()
        {
            Console.WriteLine("Payment with CreditCard");
        }

        public void PaymenWithPaypal()
        {
            throw new NotImplementedException();
        }
    }

    public class PaypalPaymen : IPayment
    {
        public void PaymenWithBitcoin()
        {
            throw new NotImplementedException();
        }

        public void PaymenWithCreditCard()
        {
            throw new NotImplementedException();
        }

        public void PaymenWithPaypal()
        {
            Console.WriteLine("Payment with Paypal");
        }
    }

    public class BitcoinPayment : IPayment
    {
        public void PaymenWithBitcoin()
        {
            Console.WriteLine("Payment with Bitcoin");
        }

        public void PaymenWithCreditCard()
        {
            throw new NotImplementedException();
        }

        public void PaymenWithPaypal()
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IPayment paypal = new PaypalPaymen();
            paypal.PaymenWithPaypal();
            //paypal.PaymenWithBitcoin(); // this is worng
            //paypal.PaymenWithCreditCard();// this is worng

            IPayment Creditcard = new CreditCardPaymen();
            //Creditcard.PaymenWithPaypal();// this is worng
            //Creditcard.PaymenWithBitcoin(); // this is worng
            Creditcard.PaymenWithCreditCard();
            IPayment Bitcoin = new BitcoinPayment();
            //Bitcoin.PaymenWithPaypal();// this is worng
            Bitcoin.PaymenWithBitcoin();
            //Bitcoin.PaymenWithCreditCard();// this is worng

            Console.ReadKey();
        }
    }
}
