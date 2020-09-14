using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var russianArmy = new Army(new RussianFactory());
            russianArmy.CreateSoldiers(5);
            russianArmy.CreateTanks(2);

            var usaArmy = new Army(new USAFactory());
            usaArmy.CreateSoldiers(50);
            usaArmy.CreateTanks(3);

            foreach (var soldier in russianArmy.Soldiers)
            {
                soldier.Move();
                soldier.Shoot();
            }

            foreach (var tank in usaArmy.Tanks)
            {
                tank.Move();
            }
        }
    }
}
