namespace DecoratorShop;

public class RedirectDecorator : IPayment
{
    private readonly IPayment _payment;

    public RedirectDecorator(IPayment payment)
    {
        _payment = payment;
    }

    public void Pay(decimal amount)
    {
        _payment.Pay(amount);
        Console.WriteLine("redirecting to main page");
    }
}
