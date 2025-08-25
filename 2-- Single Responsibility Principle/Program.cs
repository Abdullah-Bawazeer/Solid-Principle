using _2___Single_Responsibility_Principle.After;

namespace _2___Single_Responsibility_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestWithoutSRP();
            TestWitSRP();
            Console.ReadKey();
        }

        private static void  TestWithoutSRP()
        {
            var account = new Before.Account("Abdullah" ,"abb@gmail.com", 9000);
            account.MakeTransaction(500);
            account.MakeTransaction(-11000);
        }

        private static void TestWitSRP()
        {
            var account = new After.Account("Abdullah", "abb@gmail.com", 9000);
            var acoountService = new AccountService();
           
            acoountService.Deposit(account , 500);
            acoountService.WithDraw(account , -11000);
           
        }
    }
}
