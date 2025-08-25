namespace Violating_DIP___Report
{
    public class PdfGenerateReport
    {
        public void Generate()
        {
            Console.WriteLine("PDF Report Generated :-)");
        }
    }

    public class GenerateReport
    {
        PdfGenerateReport _PdfReportGenerator;
        public GenerateReport()
        {
            _PdfReportGenerator = new PdfGenerateReport();
        }

        public void Generate()
        {
            _PdfReportGenerator.Generate();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GenerateReport generateReport = new GenerateReport();
            generateReport.Generate();


            Console.ReadKey();
        }
    }
}
