namespace DecoratorShop;

public class BlikPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount} with BLIK");
    }
}

