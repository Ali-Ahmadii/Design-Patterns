namespace Factory
{
    public class ConcrateCreatorA : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ProductA();
        }
    }
}