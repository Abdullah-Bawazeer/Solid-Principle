
namespace KISS___YAGNI.Models
{
    public record Recepit
    {
        public string Id {  get;  }
        public decimal Amount {  get;  }
        public string PaymentMethod {  get;  }
        public Recepit(decimal amount, string paymentMethod)
        {
            Id = Guid.NewGuid().ToString().Substring(0,8); 
            Amount = amount;
            PaymentMethod = paymentMethod;
        }

      
    }
}
