using Decorator.Beverages;

namespace Decorator.Supplements
{
    //Concrete decorator
    public class Sugar: Supplement
    {
        protected override string SupplementName => "Sugar";
        protected override int SupplementCost => 10;

        public Sugar(Beverage beverage) : base(beverage) { }
    }
}
