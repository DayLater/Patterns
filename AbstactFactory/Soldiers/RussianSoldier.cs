using System;

namespace AbstractFactory.Soldiers
{
    public class RussianSoldier: Soldier
    {
        public override string Name => "RussianSoldier";
        public override void Move()
        {
            Console.WriteLine("RussianSoldier MOVING Quickly");
        }

        public override void Shoot()
        {
            Console.WriteLine("They use AK-47 and Vodka. Tra-ta-ta-ta for Putin");
        }
    }
}
