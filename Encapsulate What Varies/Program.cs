namespace Encapsulate_What_Varies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = Pizza.Order(PizzaConstant.VegeterianPizza);
            Console.WriteLine(pizza);


            Console.ReadKey();
        }
    }
    public class Pizza
    {
        public virtual string Title => $"{nameof(Pizza)}";
        public virtual decimal price => 10m;

        public static Pizza Creat(string type)
        {
            Pizza pizza;
            if (type.Equals(PizzaConstant.CheesePizza))
                pizza = new Cheese();
            else if (type.Equals(PizzaConstant.VegeterianPizza))
                pizza = new vegetarian();
            else
                pizza = new Chicken();
            return pizza;
        }
        public static Pizza Order(string type)
        {
            Pizza pizza = Creat(type);
           
            Propare();
            Cook();
            Cut();
            return pizza;
        }

        private static void  Propare()
        {
            Console.Write("Proparing ......");
            Thread.Sleep(500);
            Console.WriteLine("Compalted ......");
        }

        private static void Cook()
        {
            Console.Write("cooking ......");
            Thread.Sleep(500);
            Console.WriteLine("Compalted ......");
        }
        private static void Cut()
        {
            Console.Write("Cutting and Boxing ......");
            Thread.Sleep(500);
            Console.WriteLine("Compalted ......");
        }

        public override string ToString()
        {
            return $"\n{Title}" +
                $"\n\t Price :{price.ToString("C")}";
        }   
    }

    public class Cheese : Pizza
    {
        public override string Title => $"{base.Title} {nameof(Cheese)}" ; // Pizza cheese
        public override decimal price => base.price  + 3m;
    }

    public class Chicken : Pizza
    {
        public override string Title => $"{base.Title} {nameof(Chicken)}"; // Pizza cheese
        public override decimal price => base.price + 6m;
    }

    public class vegetarian : Pizza
    {
        public override string Title => $"{base.Title} {nameof(vegetarian)}"; // Pizza cheese
        public override decimal price => base.price + 4m;
    }
}
