namespace CompositeMenu;

public class Dish : IMenuItem
{
    public string Name { get; }

    public Dish(string name)
    {
        Name = name;
    }

    public void Display(int depth = 0)
    {
        Console.WriteLine($"{new string(' ', depth * 2)}- {Name}");
    }
}

