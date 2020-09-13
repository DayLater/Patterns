using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Client
    {
        private IService service;

        public Client(IService service)
        {
            this.service = service;
        }

        public void SomeAction()
        {
            Console.WriteLine("I do something");
            Console.WriteLine(service.GetInfo());
        }
    }
}
