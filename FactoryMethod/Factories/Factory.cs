using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using FactoryMethod.Products;

namespace FactoryMethod.Factories
{
    public abstract class Factory
    {
        protected List<Product> allProducts = new List<Product>();
        public abstract string Name { get; }
        public abstract Product CreateProduct();

        public void PrintAllCreatedProduct()
        {
            Console.WriteLine($"Created at factory {Name}");
            int i = 0; 
            foreach (var product in allProducts)
            {
                Console.WriteLine($"{i}. {product}");
                i++;
            }
        }
    }
}
