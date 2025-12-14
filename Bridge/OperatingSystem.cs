namespace BridgeDesktop;

public abstract class Desktop
{
    protected IInterface UserInterface;
    protected List<string> InstalledPrograms = new();

    protected Desktop(IInterface ui)
    {
        UserInterface = ui;
    }

    public abstract void ShowMenu();
}
