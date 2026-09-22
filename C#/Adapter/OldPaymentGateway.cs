namespace Adapter
{
    public class OldPaymentGateway
{
    public void MakePayment(double value)
    {
        Console.WriteLine($"Payment: {value}");
    }
}
}
