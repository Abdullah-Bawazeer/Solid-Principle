using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Single_Responsibility_Principle.Before
{
    internal class Account
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Balanace { get; set; }

        public Account(string name, string email, decimal balanace)
        {
            Name = name;
            Email = email;
            Balanace = balanace;
        }

        public void MakeTransaction(decimal amount)
        {
            var transactionMeassage = "";
            if (amount < 0)
            {
                if (Balanace < Math.Abs(amount))
                {
                    transactionMeassage =
                        $"OVERDRAFT when trying make withdraw " +
                        $"{Math.Abs(amount).ToString("C2")} , " +
                        $"Current Balanaced {Balanace.ToString("C2")}  ";
                }
                else
                {

                    
                        this.Balanace += amount;
                        transactionMeassage =
                            $"OK WIthdraw {Math.Abs(amount).ToString("C2")}" +
                            $"Current Blanace  {Balanace.ToString("C2")}";
                   
                }
            }
            else
            {
                this.Balanace -= amount;
                transactionMeassage =
                    $"OK Dispos {Math.Abs(amount).ToString("C2")}" +
                    $"Current Blanace  {Balanace.ToString("C2")}";
            }

            Console.WriteLine(
                $"\n\n\t\t TO  {Email} " +
                $"\n\t\t Subject : Fake Bank Account Activity " +
                $"\n\n\t\t Dear :   {Name} " +
                $"\n\n\t\t A recent Activity On Your Account Accures at {DateTime.Now.ToString()} " +
                $"\n\n\t\t ======> {0} " +
                $"\n\n\t\t tHANK YOU ,\n\t\t Fake Bank. " +
                $"\n\n\t\t ------------------------------------------------ " ,transactionMeassage);
        }
    }
}
