
namespace slo_KISS___YAGNI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Console.Clear();
                Console.Write("Amount : ");
                var amount = int.Parse(Console.ReadLine());
                Console.Write("Payment Method : ");
                var method = Console.ReadLine();
                var paymentService = new PaymentService();
                var recepit= paymentService.Pay(amount, method);
                Console.WriteLine("-----------------------");
                Console.WriteLine(recepit);
                Console.WriteLine("another payment press any Key  .");
                Console.ReadKey();
            } while (true);

            Console.ReadKey();
        }
    }
}
