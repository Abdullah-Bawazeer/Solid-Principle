

namespace _2___Single_Responsibility_Principle.After
{
    internal class AccountService
    {
        public void Deposit( Account account,decimal amount)
        {
            var transactionMeassage = "";
            
                if(amount > 0)
                {
                    account.Balanace -= amount;
                    transactionMeassage =
                        $"OK Dispos {Math.Abs(amount).ToString("C2")}" +
                        $"Current Blanace  {account.Balanace.ToString("C2")}";
                }
              
            var emailCliant= new EmailCliant(); 
            emailCliant.send(account , transactionMeassage ,DateTime.Now);
        }

        public void WithDraw(Account account, decimal amount)
        {
            var transactionMeassage = "";
           
                if (account.Balanace < Math.Abs(amount))
                {
                    transactionMeassage =
                        $"OVERDRAFT when trying make withdraw " +
                        $"{Math.Abs(amount).ToString("C2")} , " +
                        $"Current Balanaced {account.Balanace.ToString("C2")}  ";
                }
                else
                {


                    account.Balanace -= amount;
                    transactionMeassage =
                        $"OK WIthdraw {Math.Abs(amount).ToString("C2")}" +
                        $"Current Blanace  {account.Balanace.ToString("C2")}";

                }
         
            var emailCliant = new EmailCliant();
            emailCliant.send(account, transactionMeassage, DateTime.Now);
        }


    }
}
