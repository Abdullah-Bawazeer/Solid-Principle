using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.After
{
    internal class Repository
    {
        public static List<Customer> customers => new List<Customer>()
        {
            new Customer
            {
                Id = 1,
                Name="abdullah",
                EmailAddress="abb@gmail.com",
                MobileNo="712443749",
                Address="yemen"
            },
            new Customer
            {
                Id = 2,
                Name="ali",
                EmailAddress="ali@gmail.com",
                MobileNo="712443749",
                Address="yemen"
            },
            new Customer
            {
                Id = 2,
                Name="sara",
                EmailAddress="sara@gmail.com",
                MobileNo="712443749",
                Address="yemen"
            },
        };
           

    }
}
