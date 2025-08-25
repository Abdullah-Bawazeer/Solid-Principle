namespace Slo__Applying_ISP___Printer
{
    public interface IPrint
    {
        void Print(string content);
    }
    public interface IScan
    {
        public void Scan();
    }

    public interface IFax
    {
        public void Fax();
    }
    public interface ICopy
    {
        public void Copy();
    }

    public class BasicPrinter : IPrint
    {
        public void Print(string content)
        {
            Console.WriteLine($"Print  : {content}");
        }
    }


    public class AdvancPrinter : IPrint, IFax, IScan, ICopy
    {
        public void Copy()
        {
            Console.WriteLine("Coping .... ");
        }

        public void Fax()
        {
            Console.WriteLine("Faxing .... ");
        }

        public void Print(string content)
        {
            Console.WriteLine($"Print  : {content}");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning .... ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicPrinter basicPrinter = new BasicPrinter();
            basicPrinter.Print("Hi ' My Name IS Abdullah Bawazeer");
            AdvancPrinter advancPrinter = new AdvancPrinter();
            advancPrinter.Print("Hi ' My Name IS Abdullah Bawazeer");
            advancPrinter.Scan();
            advancPrinter.Fax();
            advancPrinter.Copy();
            Console.ReadKey();
        }
    }
}
