namespace CommandSanta;

public class SantaClausFactory
{
    public void ProduceToy(string name)
    {
        Console.WriteLine($"Factory produced a toy: {name}");
    }

    public void ProduceRod()
    {
        Console.WriteLine("Factory produced a rod for naughty children");
    }
}
