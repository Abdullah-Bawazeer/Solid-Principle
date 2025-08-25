using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.After
{
    internal class WhatsappService : IMessageService
    {
        public string number { get; set; }
        public void Send()
        {
            Console.WriteLine($"whatsapp message  is  sent to {number}");
        }
    }
}
