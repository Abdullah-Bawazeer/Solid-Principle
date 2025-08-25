using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.After
{
    internal class EmailService :IMessageService
    {
        public string EmailAddress { get; set; }
        public void Send()
        {
            Console.WriteLine($"email is  sent to {EmailAddress}");
        }
    }
}
