namespace DecoratorShop;

public class CashPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount} with cash");
    }
}

