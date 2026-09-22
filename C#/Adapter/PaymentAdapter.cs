namespace Adapter
{
  public class PaymentAdapter : IPaymentProcessor
{
    private readonly OldPaymentGateway _gateway;

    public PaymentAdapter(OldPaymentGateway gateway)
    {
        _gateway = gateway;
    }

    public void Pay(decimal amount)
    {
        _gateway.MakePayment((double)amount);
    }
}  
}
