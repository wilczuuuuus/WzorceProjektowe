namespace BridgeDesktop;

public class ConsoleInterface : IInterface
{
    public void DisplayMenu(List<string> programs)
    {
        for (int i = 0; i < programs.Count; i++)
            Console.WriteLine($"  {i + 1}. {programs[i]}");
    }
}
