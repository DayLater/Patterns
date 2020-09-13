using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Products
{
    public abstract class Product
    {
        public abstract string Name { get; }
        public abstract int Cost { get; }

        public override string ToString()
        {
            return $"{Name} with cost: {Cost}";
        }
    }
}
