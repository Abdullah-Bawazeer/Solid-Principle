using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Before
{
    class DayLabourer : Employee, IEntitlement
    {
        public decimal CalculateBonuses()
        {
            throw new NotImplementedException("DayLabourer Bonueses not supported");
        }

        public decimal CalculateHealthInsurance() => 300m;
       

        public decimal CalculatePension() 
        {
            throw new NotImplementedException("DayLabourer Pension( not supported");
        }

        public decimal CalculateRentalSubsidy()
        {
            throw new NotImplementedException("DayLabourer RentalSubsidy not supported");
        }

        public decimal CalculateTransportationReimburesement() => 150m;
        

        public override string PrintSalarySlip()
        {
            return $"\n---{nameof(DayLabourer)} ----- " +
             $"\n NO. : {EmployeeNo} " +
             $"\n Name  : {Name}" +
             $"\n Basic Salary  : {Salary.ToString("C2")}" +
             $"\n Health Insurance : {CalculateHealthInsurance().ToString("C2")}" +
             $"\n Transportation Reimbursement  : {CalculateTransportationReimburesement().ToString("C2")}" +
             $"\n--------------------------------------------------------" +
             $"\n Net Salary : {CalculateNetSalary().ToString("C2")}";
        }

        protected override decimal CalculateNetSalary()
        {
            return Salary + CalculateHealthInsurance () + CalculateTransportationReimburesement();
        }
    }
}
