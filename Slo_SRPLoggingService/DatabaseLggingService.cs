using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slo_SRPLoggingService
{
    public class DatabaseLggingService
    {
        public static void Log(string message)
        {
            Console.WriteLine($"Database   : {message}");
        }
    }
}
