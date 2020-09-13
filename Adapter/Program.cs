using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var neededService = new NeededService();
            var adaptedService = new AdapterService(neededService);

            var client = new Client(adaptedService);
            client.SomeAction();
        }
    }
}
