namespace Violating_LSP___Bird
{
    public class bird
    {
        public virtual void Eat()
        {
            Console.WriteLine("Eat ....");
        }

        public virtual void Flay()
        {
            Console.WriteLine("Faly ....");
        }
    }
    public class Eagle :bird
    {
        public override void Eat()
        {
            Console.WriteLine("Eagle eat ... ");
        }

        public override void Flay()
        {
            Console.WriteLine("Eagle Flay ... ");
        }
    }

    public class Ostrich : bird
    {
        public override void Eat()
        {
            Console.WriteLine("Ostrich Eat ... ");
        }

        /// <summary>
        ///  Ostrich cam not flay
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public override void Flay()
        {
            throw new NotImplementedException("Ostrich can't flay");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bird Eagly = new Eagle();
            Eagly.Eat();
            Eagly.Flay();
            bird Ostrich = new Ostrich();
            Ostrich.Eat();
            //Ostrich.Flay();
            Console.ReadKey();
        }
    }
}
