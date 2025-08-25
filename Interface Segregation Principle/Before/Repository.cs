using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Interface_Segregation_Principle.Before
{
     class Repository
    {
        public static IEnumerable<Employee> LoadEmployees()
        {
            return new List<Employee>
            {
                new Staff
                {
                    EmployeeNo = "N61291",
                    Name ="abdullah",
                    Salary = 9000
                },
                 new DayLabourer
                 {
                     EmployeeNo = "N61291",
                     Name = "abdullah",
                     Salary = 9000
                 }
                ,
                new Consultant
{
                    EmployeeNo = "N61291",
                     Name = "abdullah",
                     Salary = 9000
                }
            };
        }
    }
}
