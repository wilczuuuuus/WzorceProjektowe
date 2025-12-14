namespace BridgeDesktop;

public class GraphicInterface : IInterface
{
    public void DisplayMenu(List<string> programs)
    {
        foreach (var program in programs)
            Console.WriteLine($"  [{program}]");
    }
}
