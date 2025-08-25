using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Single_Responsibility_Principle.After
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
    }
}
