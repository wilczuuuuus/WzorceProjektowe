namespace DecoratorShop;

public class CardPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount} with card");
    }
}

