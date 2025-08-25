using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_substitution_principle.Before
{
    internal class savingAccount :Account
    {
        public savingAccount(string name, decimal balance) : base(name, balance)
        {
            
        }

        public override void Deposit(decimal amount)
        {
            Balanace += amount;
        }

        public override void Withdraw(decimal amount)
        {
            if (amount > 1000)
            {
                Console.WriteLine($"you can not withdraw more than 1000");
                return;
            }
            Balanace -= amount;
        }
    }
}
