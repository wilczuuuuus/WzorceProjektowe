using BridgeDesktop;

var gui = new GraphicInterface();
var cli = new ConsoleInterface();

var systems = new Dictionary<string, Desktop>
{
    { "1", new WindowsSystem(gui) },
    { "2", new LinuxSystem(gui) },
    { "3", new LinuxSystem(cli) }
};

while (true)
{
    Console.WriteLine("Select system:");
    Console.WriteLine("1. Windows (GUI)");
    Console.WriteLine("2. Linux (GUI)");
    Console.WriteLine("3. Linux (CLI)");
    Console.WriteLine("0. Exit");

    var choice = Console.ReadLine();

    if (choice == "0" || choice == null)
        break;

    if (systems.TryGetValue(choice, out var system))
        system.ShowMenu();

    Console.WriteLine();
}
