using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Products
{
    public class Meat: Product
    {
        public override string Name => "SuperMeat";
        public override int Cost => 550;
    }
}
