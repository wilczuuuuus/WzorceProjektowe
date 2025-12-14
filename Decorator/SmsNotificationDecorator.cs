namespace DecoratorShop;

public class SmsNotificationDecorator : IPayment
{
    private readonly IPayment _payment;

    public SmsNotificationDecorator(IPayment payment)
    {
        _payment = payment;
    }

    public void Pay(decimal amount)
    {
        _payment.Pay(amount);
        Console.WriteLine("SMS notification sent");
    }
}
