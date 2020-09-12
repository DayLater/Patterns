using Decorator.Beverages;

namespace Decorator.Supplements
{
    //Concrete decorator
    public class Milk: Supplement
    {
        public Milk(Beverage beverage) : base(beverage) { }

        protected override string SupplementName => "Milk";
        protected override int SupplementCost => 20;
    }
}
