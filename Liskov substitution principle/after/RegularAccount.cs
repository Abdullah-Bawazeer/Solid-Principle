namespace Liskov_substitution_principle.after
{
    abstract class RegularAccount :Account
    {
        public string name { get; set; }
        public decimal Balanace { get; set; }
        public RegularAccount(string name, decimal balanace) :base(name ,balanace) 
        {
          
        }
        public abstract void Withdraw(decimal amount);

    }
}
