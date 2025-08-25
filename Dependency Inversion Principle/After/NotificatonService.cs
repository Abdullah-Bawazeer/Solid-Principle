using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.After
{
    internal class NotificatonService
    {
        public readonly List<IMessageService> _services;
        

        public NotificatonService(List<IMessageService> services)
        {
            _services = services;
        }

        public void Notify()
        {
            foreach (var service in _services)
            {
                service.Send();
            }
        }

    }

    internal class NotificatonService1
    {
        public List<IMessageService> Service { get; set; } =new();

        public void Notify()
        {
            foreach (var service in Service)
            {
                service.Send();
            }
        }

    }
}
