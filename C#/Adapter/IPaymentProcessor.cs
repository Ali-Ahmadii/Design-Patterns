namespace Adapter
{
    public interface IPaymentProcessor
    {
        void Pay(decimal amount);
    }
}