namespace Slo_DIP___Report
{
    public interface IReportGenerator
    {
        public void Generate();
    }

    public class PDFReportGenerator : IReportGenerator
    {
        public void Generate()
        {
            Console.WriteLine("PDF Report Generated :-)");
        }
    }

    public class ExcelReoprtGenerator : IReportGenerator
    {
        public void Generate()
        {
            Console.WriteLine("Excel Report Generated :-)");

        }
    }
    public class WordReoprtGenerator : IReportGenerator
    {
        public void Generate()
        {
            Console.WriteLine("Word Report Generated :-)");

        }
    }


    public class ReportGenerator
    {
        public IReportGenerator _reportGenerator;

        public ReportGenerator(IReportGenerator reportGenerator)
        {
            this._reportGenerator = reportGenerator;
        }

        public void GenerateReport()
        {
            _reportGenerator.Generate();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ReportGenerator reportGenerator = new ReportGenerator(new PDFReportGenerator());
            reportGenerator.GenerateReport();
            reportGenerator = new ReportGenerator(new ExcelReoprtGenerator());
            reportGenerator.GenerateReport();
            reportGenerator = new ReportGenerator(new WordReoprtGenerator());
            reportGenerator.GenerateReport();
            Console.ReadKey();
        }
    }
}
