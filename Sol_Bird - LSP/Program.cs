namespace Sol_Bird___LSP
{
    public class Bird
    {
        public virtual void Eat()
        {
            Console.WriteLine("Eat ... ");
        }
    }

    public class FlayingBird : Bird
    {
        public virtual void Flay()
        {
            Console.WriteLine("Flaying .... ");
        }
    }

    public class Eagle : FlayingBird
    {
        public override void Eat()
        {
            Console.WriteLine("Eagle Eat");
        }

        public override void Flay()
        {
            Console.WriteLine("Eagle Flayin .... ");
        }
    }

    public class Ostrich : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Ostrich Eat ....");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FlayingBird eagle = new Eagle();
            eagle.Eat();
            eagle.Flay();
            Bird ostrich = new Ostrich();
            ostrich.Eat();
            Console.ReadKey();
        }
    }
}
