namespace BridgeDesktop;

public class WindowsSystem : Desktop
{
    public WindowsSystem(IInterface ui) : base(ui)
    {
        InstalledPrograms = new List<string> { "Word", "Excel", "Notepad", "Calculator" };
    }

    public override void ShowMenu()
    {
        Console.WriteLine("Windows Apps:");
        UserInterface.DisplayMenu(InstalledPrograms);
    }
}
