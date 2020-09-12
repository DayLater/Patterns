using Decorator.Beverages;

namespace Decorator.Supplements
{
    //Base decorator 
    public abstract class Supplement: Beverage
    {
        private Beverage beverage;
        protected abstract string SupplementName { get; }
        protected abstract int SupplementCost { get; }

        public override string Description => $"{beverage?.Description} + {SupplementName}";
        public override int Cost => beverage.Cost + SupplementCost;

        protected Supplement(Beverage beverage)
        {
            this.beverage = beverage;
        }
    }
}
