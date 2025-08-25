namespace Violating_LSP___Vehicle
{
    public class Vehicle
    {
        public virtual void StartEngin()
        {
            Console.WriteLine("\n Starting Engign .... ");
        }

        public virtual void Drive()
        {
            Console.WriteLine("Driving ..... ");
        }
    }

    public class Car : Vehicle
    {
        public override void StartEngin()
        {
            Console.WriteLine("Car Starting Engin .... ");
        }


        public override void Drive()
        {
            Console.WriteLine("Car Drive ....");
        }
    }

    public class Bicycle : Vehicle
    {
        public override void Drive()
        {
           Console.WriteLine(" Bicycle Drive ..... ");
        }

        public override void StartEngin()
        {
            Console.WriteLine("Bicycle Can not Engin .... ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car();
            car.Drive();
            car.StartEngin();
            Vehicle bicycle = new Bicycle();
            bicycle.StartEngin();
            bicycle.Drive();
            Console.ReadKey();
        }
    }
}
