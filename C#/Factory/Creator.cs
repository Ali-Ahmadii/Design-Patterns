namespace Factory
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();
        public int GetID()
        {
            var product = FactoryMethod();
            return product.ID();
        }
    }
}