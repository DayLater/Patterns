using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Soldiers;
using AbstractFactory.Tanks;

namespace AbstractFactory.Factories
{
    public class RussianFactory: Factory
    {
        public override Soldier CreateSoldier()
        {
            return new RussianSoldier();
        }

        public override Tank CreateTank()
        {
            return new RussianTank();
        }
    }
}
