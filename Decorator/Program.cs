using System;
using Decorator.Beverages;
using Decorator.Supplements;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var teaWithSugarAndMilk = new Milk(new Sugar(new Tea()));
            var coffeeWithChocolate = new Chocolate(new Coffee());
            Console.WriteLine(coffeeWithChocolate);
            Console.WriteLine(teaWithSugarAndMilk);
        }
    }
}
