using System;

namespace AbstractFactory.Soldiers
{
    public class USASoldier: Soldier
    {
        public override string Name => "USA Soldier";

        public override void Move()
        {
            Console.WriteLine("USA is moving for oil");
        }

        public override void Shoot()
        {
            Console.WriteLine("Usa soldier use M-16 and fight for oil and burger");
        }
    }
}
