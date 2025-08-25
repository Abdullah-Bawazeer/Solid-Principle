using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.After
{
    internal class SMSService :IMessageService
    {
        public string MobileNo { get; set; }
        public void Send()
        {
            Console.WriteLine($"SMS send to {MobileNo}");
        }
    }
}
