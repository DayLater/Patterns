using System;

namespace AbstractFactory.Tanks
{
    public class RussianTank: Tank
    {
        public override string Name => "Russian Tank";

        public override void Move()
        {
            Console.WriteLine("We're go for the PUTIN. RUSSIAN TANKS ARE THE BEST");
        }
    }
}
