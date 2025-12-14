namespace DecoratorShop;

public class Shop
{
    public void ProcessPayment(decimal amount, string method)
    {
        IPayment payment = method.ToLower() switch
        {
            "cash" => new CashPayment(),
            "card" => new CardPayment(),
            "blik" => new BlikPayment(),
            _ => throw new ArgumentException("Unknown payment method")
        };

        if (method.ToLower() == "card")
        {
            payment = new SmsNotificationDecorator(payment);
            payment = new LoyaltyPointsDecorator(payment);
            payment = new RedirectDecorator(payment);
        }

        payment.Pay(amount);
    }
}

