namespace Violating_LSP___Person
{
    internal class Program
    {
        public class Person
        {
            public virtual void PaySalary()
            {
                Console.WriteLine("Pay Salary to a Person ...");
            }

            public virtual void SendEmail()
            {
                Console.WriteLine("Send Email to a Person");
            }
        }

        public class Employee : Person
        {
            public override void PaySalary()
            {
                Console.WriteLine("Pay Salary to an Employee ... ");
            }
            public override void SendEmail()
            {
                Console.WriteLine("Send Email to an Employrr");
            }
        }

        public class Manger :Employee
        {
            public override void PaySalary()
            {
                Console.WriteLine("Pay Salary to an Manger ... ");
            }
            public override void SendEmail()
            {
                Console.WriteLine("Send Email to an Manger");
            }
        }

        public class Student : Person
        {
            public override void PaySalary()
            {
               throw new InvalidOperationException (" Studnet  not Recive   Salary ... ");
            }
            public override void SendEmail()
            {
                Console.WriteLine("Send Email to an Student");
            }
        }

        public class User : Person
        {
            public override void PaySalary()
            {
                throw new InvalidOperationException(" User  not Recive   Salary ... ");
            }
            public override void SendEmail()
            {
                Console.WriteLine("Send Email to an User");
            }
        }
        static void Main(string[] args)
        {
            Person employee = new Employee();
            employee.PaySalary();
            employee.SendEmail();

            Person manger = new Manger();
            manger.PaySalary();
            manger.SendEmail();

            Person student = new Student();
            student.PaySalary();
            student.SendEmail();
            Person user = new User();
            user.PaySalary();
            user.SendEmail();

            Console.WriteLine("Hello, World!");
        }
    }
}
