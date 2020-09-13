using FactoryMethod.Products;

namespace FactoryMethod.Factories
{
    public class MeatFactory: Factory
    {
        public override string Name => "Super meat";

        public override Product CreateProduct()
        {
            var meat = new Meat();
            allProducts.Add(meat);
            return meat;
        }
    }
}
