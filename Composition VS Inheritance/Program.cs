namespace Composition_VS_Inheritance
{
   namespace Encapsulate_What_Varies
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                var Choise = 0;
                var pizza = new Pizza();
                do
                {
                    Console.Clear();
                    Choise = ReadChoise(Choise);
                    if(Choise>= 0 && Choise <= 5)
                    {
                        ITopping topping = null;
                       switch(Choise)
                        {
                            case 1:
                                topping = new Tomato();
                                break;
                            case 2:
                                topping = new Chicken();
                                break;
                            case 3:
                                topping = new Cheese();
                                break;
                            case 4:
                                topping = new BlackOlive();
                                break;
                            case 5:
                                topping = new GreenPapre();
                                break;
                            default:break;
                               
                        }
                        pizza.AddTopping(topping);
                        Console.WriteLine("press any key to Continue .... ");
                    }
                    Console.ReadKey();

                }while (Choise != 0);


                Console.WriteLine(pizza);
                Console.ReadKey();
            }

            public static int ReadChoise(int choice)
            {
                Console.WriteLine("Available Topping : ");
                Console.WriteLine("-------------------");
                Console.WriteLine("1. Tomato");
                Console.WriteLine("2. Chicken");
                Console.WriteLine("3. cheese");
                Console.WriteLine("4. Balck Olives");
                Console.WriteLine("5. Green Paper ");
                Console.WriteLine("What is your choise ?");
                if (int.TryParse(Console.ReadLine(), out int ch))
                {
                    choice = ch;
                }
                return choice;
                
            }
        
        }
        public class Pizza
        {
          
            public virtual decimal price => 10m;
            public List<ITopping> Toppings { get; private set; } = new List<ITopping>();
            public void AddTopping(ITopping toping) => Toppings.Add(toping);

            private decimal Calculate()
            {
                var total = price;
                foreach (var item in Toppings)
                {
                    total += item.price;
                }
                return total;
            }
            public override string ToString()
            {
                var OutPut = $"\n{nameof(Pizza)}";
                OutPut = $"\n\t Base Price  ({price.ToString("C")})";
                foreach(var toppinf in Toppings)
                {
                    OutPut += $"\n\t {toppinf.Title}  ({toppinf.price.ToString("C")})" ;
                }
                OutPut += "\n------------------------------------";
                OutPut += $"\n Total : {Calculate().ToString("C")}";
                return OutPut;
            }
        }


        public interface ITopping
        {
            string Title { get; }
            decimal price { get; }
        }

        public class Tomato : ITopping
        {
            public string Title => nameof(Tomato);

            public decimal price => 3m;
        }

        public class Chicken : ITopping
        {
            public string Title => nameof(Chicken);

            public decimal price => 6m;
        }

        public class Cheese : ITopping
        {
            public string Title => nameof(Cheese);

            public decimal price => 4m;
        }

        public class BlackOlive : ITopping
        {
            public string Title => nameof(BlackOlive);

            public decimal price => 8m;
        }

        public class GreenPapre : ITopping
        {
            public string Title => nameof(GreenPapre);

            public decimal price => 2m;
        }

    }

}
