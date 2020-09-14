using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Soldiers;
using AbstractFactory.Tanks;

namespace AbstractFactory
{
    public abstract class Factory
    {
        public abstract Soldier CreateSoldier();
        public abstract Tank CreateTank();
    }
}
