using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Products;

namespace FactoryMethod.Factories
{
    public class MilkFactory: Factory
    {
        public override string Name => "Home milk";

        public override Product CreateProduct()
        {
           var milk = new Milk("SuperMilk", 100);
           allProducts.Add(milk);
           return milk;
        }
    }
}
