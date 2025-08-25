namespace Slo_Violating_LSP___Person
{
    public class Person
    {
      
        public virtual void SendEmail()
        {
            Console.WriteLine("Send Email to a Person");
        }
    }

    public class Employee : Person
    {
        public virtual void PaySalary()
        {
            Console.WriteLine("Pay Salary to an Employee ... ");
        }
        public override void SendEmail()
        {
            Console.WriteLine("Send Email to an Employrr");
        }
    }

    public class Manger : Employee
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
       
        public override void SendEmail()
        {
            Console.WriteLine("Send Email to an Student");
        }
    }

    public class User : Person
    {
       
        public override void SendEmail()
        {
            Console.WriteLine("Send Email to an User");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.PaySalary();
            employee.SendEmail();

            Manger manger = new Manger();
            manger.PaySalary();
            manger.SendEmail();

            Person student = new Student();
            student.SendEmail();
            Person user = new User();
            user.SendEmail();


            Console.ReadKey();
        }
    }
}
