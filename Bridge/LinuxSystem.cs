namespace BridgeDesktop;

public class LinuxSystem : Desktop
{
    public LinuxSystem(IInterface ui) : base(ui)
    {
        InstalledPrograms = new List<string> { "Firefox", "LibreOffice", "Terminator", "VLC" };
    }

    public override void ShowMenu()
    {
        Console.WriteLine("Linux Apps:");
        UserInterface.DisplayMenu(InstalledPrograms);
    }
}
