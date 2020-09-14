using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.UsefulClasses;

namespace Facade
{
    public class FacadeClass
    {
        private FirstClass first;
        private ThirdClass third;
        private SecondClass second;

        public FacadeClass(FirstClass first, SecondClass second, ThirdClass third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }

        public void ComfortableMethod()
        {

            Console.WriteLine(first.UsefulAction());
            var result = second.UsefulAction();
            Console.WriteLine(third.AnotherAction(result));
        }
    }
}
