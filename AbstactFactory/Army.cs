using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Soldiers;
using AbstractFactory.Tanks;

namespace AbstractFactory
{
    public class Army
    {
        private readonly Factory factory;
        public List<Soldier> Soldiers { get; }
        public List<Tank> Tanks { get; }

        public Army(Factory factory)
        {
            Soldiers = new List<Soldier>();
            Tanks = new List<Tank>();
            this.factory = factory;
        }

        public void CreateSoldiers(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var soldier = factory.CreateSoldier();
                Soldiers.Add(soldier);
            }
        }

        public void CreateTanks(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var tank = factory.CreateTank();
                Tanks.Add(tank);
            }
        }
    }
}
