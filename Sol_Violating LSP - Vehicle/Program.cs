namespace Sol_Violating_LSP___Vehicle
{
    public class Vehicle
    {
       
        public virtual void Drive()
        {
            Console.WriteLine("Driving ..... ");
        }
    }

    public class MotorVehicle : Vehicle
    {
        public virtual void StartEngin()
        {
            Console.WriteLine("\n Starting Engign .... ");
        }
    }

    public class Car : MotorVehicle
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

         
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MotorVehicle car = new Car();
            car.Drive();
            car.StartEngin();
            Vehicle bicycle = new Bicycle();
            bicycle.Drive();
            Console.ReadKey();
        }
    }
}
