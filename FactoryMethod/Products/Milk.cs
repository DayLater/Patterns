using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Products
{
    public class Milk: Product
    {
        public override string Name { get; }
        public override int Cost { get; }

        public Milk(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }

    }
}
