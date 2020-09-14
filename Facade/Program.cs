using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.UsefulClasses;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = new FirstClass();
            var second = new SecondClass();
            var third = new ThirdClass();

            var facade = new FacadeClass(first, second, third);
            facade.ComfortableMethod();
        }
    }
}
