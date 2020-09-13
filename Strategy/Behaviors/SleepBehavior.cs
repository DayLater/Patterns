using System;

namespace Strategy.Behaviors
{
    public class SleepBehavior: IBehavior
    {
        public void Do()
        {
            Console.WriteLine("Im sleeping");
        }
    }
}
