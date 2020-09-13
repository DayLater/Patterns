using System;

namespace Strategy.Behaviors
{
    public class RunBehavior: IBehavior
    {
        public void Do()
        {
            Console.WriteLine("Im running");
        }
    }
}
