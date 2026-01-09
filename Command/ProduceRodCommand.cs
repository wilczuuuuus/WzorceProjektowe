namespace CommandSanta;

public class ProduceRodCommand : ICommand
{
    private readonly SantaClausFactory _factory;

    public ProduceRodCommand(SantaClausFactory factory)
    {
        _factory = factory;
    }

    public void Execute()
    {
        _factory.ProduceRod();
    }
}
