using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Factories;
using FactoryMethod.Products;

namespace FactoryMethod
{
    public class Shop
    {
        public List<Product> AvailableProducts { get; } = new List<Product>();

        public void GetProductsFromFactory(Factory factory)
        {
            for (int i = 0; i < 10; i++)
                AvailableProducts.Add(factory.CreateProduct());
        }
    }
}
