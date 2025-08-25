namespace Violating_ISP___Printer
{
    internal class Program
    {
        public interface IPrinter
        {
            void Print(string content);
            void Scan();
            void Fax();
        }

        public class BasicPrinter : IPrinter
        {
            public void Fax()
            {
                // this type of ptiny not have Fax
                throw new NotImplementedException();
            }

            public void Print(string content)
            {
                Console.WriteLine($"Print {content}");
            }

            public void Scan()
            {
                // this type of ptiny not havr Scan
                throw new NotImplementedException();
            }
        }

        public class AdvancedPriner : IPrinter
        {
            public void Fax()
            {
                Console.WriteLine($"Fax .....");
            }

            public void Print(string content)
            {
                Console.WriteLine($"Print {content}");
            }

            public void Scan()
            {
                Console.WriteLine($"Scan ..... ");
            }
        }
        static void Main(string[] args)
        {
            BasicPrinter basicprinter = new BasicPrinter();
            basicprinter.Print("Hi , My Name Is Abdullah  Bawazeer");
            //basicprinter.Scan();
            //basicprinter.Fax();
            AdvancedPriner advincedprinter = new AdvancedPriner();
            advincedprinter.Print("Hi , My Name Is Abdullah  Bawazeer");
            advincedprinter.Scan();
            advincedprinter.Fax();
            Console.ReadKey();
        }
    }
}
