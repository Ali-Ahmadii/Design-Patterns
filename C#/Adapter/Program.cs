namespace Adapter
{
    public class Program
    {
    public static void Main()
    {
        var gateway = new OldPaymentGateway();

        IPaymentProcessor processor = new PaymentAdapter(gateway);

        var checkout = new CheckoutService(processor);

        checkout.Checkout(100m);
    }
    }
}