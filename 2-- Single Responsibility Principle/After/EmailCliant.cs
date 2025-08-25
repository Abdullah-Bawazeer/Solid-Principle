using _2___Single_Responsibility_Principle.Before;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Single_Responsibility_Principle.After
{
    internal class EmailCliant
    {
        public void send(Account account , string transactionMeassage , DateTime transactionDate)
        {
            Console.WriteLine(
             $"\n\n\t\t TO  {account.Email} " +
            $"\n\t\t Subject : Fake Bank Account Activity " +
             $"\n\n\t\t Dear :   {account.Name} " +
             $"\n\n\t\t A recent Activity On Your Account Accures at {transactionDate.ToString("yyyyy-MM-dd hh:mm")} " +
             $"\n\n\t\t ======> {0} " +
             $"\n\n\t\t tHANK YOU ,\n\t\t Fake Bank. " +
             $"\n\n\t\t ------------------------------------------------ ", transactionMeassage);
        }
    }
}
