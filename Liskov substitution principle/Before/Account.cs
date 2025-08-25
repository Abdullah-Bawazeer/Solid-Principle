using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_substitution_principle.Before
{
    abstract class Account
    {
        public string name { get; set; }
        public decimal Balanace { get; set; }
        public Account(string name, decimal balanace)
        {
            this.name = name;
            Balanace = balanace;
        }

        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);
        
    }
}
