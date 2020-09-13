using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Behaviors;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var runBehavoir = new RunBehavior();
            var sleepBehavior = new SleepBehavior();

            var person = new Person(sleepBehavior);
            person.Do();

            Console.WriteLine("Press any key to change behavior");
            Console.ReadKey();
            Console.WriteLine();
            person.SetBehavior(runBehavoir);
            person.Do();

            Console.Read();
        }
    }
}
