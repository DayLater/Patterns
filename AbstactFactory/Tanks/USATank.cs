using System;

namespace AbstractFactory.Tanks
{
    public class USATank: Tank
    {
        public override string Name => "USA Tank";
        public override void Move()
        {
            Console.WriteLine("We're use oil to find oil. USA TANKS FOR OIL");
        }
    }
}
