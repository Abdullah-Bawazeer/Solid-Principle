using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Before
{
    internal class NotificatonService
    {
        private readonly Customer customer;
        private readonly EmailService emailService;
        private readonly SMSService sMSService;

        public NotificatonService(Customer customer)
        {
            this.customer = customer;
            emailService = new EmailService
            {
                EmailAddress = customer.Address,
            };
            sMSService = new SMSService
            {
                MobileNo = customer.MobileNo,
            };
        }

        public void Notify()
        {
            emailService.Send();
           sMSService.Send();
        }

       

    }
}
