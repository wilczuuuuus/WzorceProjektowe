namespace DecoratorShop;

public class LoyaltyPointsDecorator : IPayment
{
    private readonly IPayment _payment;

    public LoyaltyPointsDecorator(IPayment payment)
    {
        _payment = payment;
    }

    public void Pay(decimal amount)
    {
        _payment.Pay(amount);
        var points = (int)(amount * 10);
        Console.WriteLine($"adding {points} loyalty points");
    }
}
