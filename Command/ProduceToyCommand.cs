namespace CommandSanta;

public class ProduceToyCommand : ICommand
{
    private readonly SantaClausFactory _factory;
    private readonly string _toyName;

    public ProduceToyCommand(SantaClausFactory factory, string toyName)
    {
        _factory = factory;
        _toyName = toyName;
    }

    public void Execute()
    {
        _factory.ProduceToy(_toyName);
    }
}
