using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Before
{
    internal class Staff : Employee, IEntitlement
    {
        public decimal CalculateBonuses() => 150m;


        public decimal CalculateHealthInsurance() => 300m;


        public decimal CalculatePension() => 500m;


        public decimal CalculateRentalSubsidy() => 200m;
        

        public decimal CalculateTransportationReimburesement()
        {
            throw new NotImplementedException("No");
        }

        public override string PrintSalarySlip()
        {
            throw new NotImplementedException();
        }

        protected override decimal CalculateNetSalary()
        {
            throw new NotImplementedException();
        }
    }
}
