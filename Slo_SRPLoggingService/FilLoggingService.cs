using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slo_SRPLoggingService
{
    public class FilLoggingService
    {
        public static void log(string message)
        {
            Console.WriteLine($"ToFile     : {message}");
        }
    }
}
