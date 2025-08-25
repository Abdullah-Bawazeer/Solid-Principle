using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLoggingService
{
    public interface IPaymentProcessor
    {
        public void Process(string From, string To, int amount);
    }
}
