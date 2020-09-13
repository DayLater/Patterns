using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Factories;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var meatFactory =new MeatFactory();
            var milkFactory = new MilkFactory();

            var shop = new Shop();
            shop.GetProductsFromFactory(meatFactory);
            shop.GetProductsFromFactory(milkFactory);
            int i = 0;
            foreach (var product in shop.AvailableProducts)
            {
                Console.WriteLine($"{i}. {product}");
                i++;
            }
            Console.WriteLine(new string('#', 30));
            meatFactory.PrintAllCreatedProduct();
            milkFactory.PrintAllCreatedProduct();
        }
    }
}
