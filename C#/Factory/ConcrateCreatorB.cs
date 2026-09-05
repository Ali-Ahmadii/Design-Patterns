namespace Factory
{
    public class ConcrateCreatorB : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ProductB();
        }
        
    }
}