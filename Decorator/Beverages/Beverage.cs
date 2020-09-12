namespace Decorator.Beverages
{
    //Base component
    public abstract class Beverage
    {
        public abstract string Description { get; }
        public abstract int Cost { get; }
        public override string ToString()
        {
            return $"{Description} with Cost: {Cost}";
        }
    }
}
