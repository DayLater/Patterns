using Decorator.Beverages;

namespace Decorator.Supplements
{
    //Concrete decorator
    public class Chocolate: Supplement
    {
        public Chocolate(Beverage beverage) : base(beverage) {}

        protected override string SupplementName => "Chocolate";
        protected override int SupplementCost => 50;
    }
}
