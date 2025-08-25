using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.After
{
    internal class Staff : Employee, IHealthInsuranceEntitlement, IPensionEntitlement, ITransportationReimburesementEntitlement, IBonusesEntitlement
    {
        public decimal CalculateBonuses()
        {
            throw new NotImplementedException();
        }

        public decimal CalculateHealthInsurance()
        {
            throw new NotImplementedException();
        }

        public decimal CalculatePension()
        {
            throw new NotImplementedException();
        }

        public decimal CalculateTransportationReimburesement()
        {
            throw new NotImplementedException();
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
