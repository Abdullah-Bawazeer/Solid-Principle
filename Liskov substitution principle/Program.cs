namespace Liskov_substitution_principle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //var account = new Before.FixedDepositAccount("Abdullah", 8000);
            //account.Withdraw(1000);

            var account = new after.FixedDepositAccount("Abdullah", 8000);
            // account.Withdraw(1000); error this is not valid operation
            account.Deposit(1000);

            Console.ReadKey();
        }
    }
}
