using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_substitution_principle.Before
{
    internal class FixedDepositAccount : Account
    {
        public FixedDepositAccount(string name, decimal balance) : base(name, balance)
        {

        }

        public override void Deposit(decimal amount)
        {
            Balanace += amount;
        }

        public override void Withdraw(decimal amount)
        {
            throw new NotImplementedException("you can't withdraw from fixes depsoit account");
        }
    }
}
