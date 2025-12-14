using DecoratorShop;

var shop = new Shop();

while (true)
{
    Console.WriteLine("\nSelect payment method:");
    Console.WriteLine("1. Cash");
    Console.WriteLine("2. Card");
    Console.WriteLine("3. BLIK");
    Console.WriteLine("0. Exit");

    var input = Console.ReadLine();

    if (!int.TryParse(input, out int choice) || choice == 0)
        break;

    var method = choice switch
    {
        1 => "cash",
        2 => "card",
        3 => "blik",
    };

    if (string.IsNullOrEmpty(method))
        continue;

    Console.Write("Enter amount: ");
    var amountInput = Console.ReadLine();

    if (!decimal.TryParse(amountInput, out decimal amount))
        continue;

    Console.WriteLine();
    shop.ProcessPayment(amount, method);
}

