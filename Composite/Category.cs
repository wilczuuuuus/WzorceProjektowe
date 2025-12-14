namespace CompositeMenu;

public class Category : IMenuItem
{
    public string Name { get; }
    private readonly List<IMenuItem> _items = new();

    public Category(string name)
    {
        Name = name;
    }

    public void Add(IMenuItem item)
    {
        _items.Add(item);
    }

    public void Display(int depth = 0)
    {
        Console.WriteLine($"{new string(' ', depth * 2)}[{Name}]");
        foreach (var item in _items)
            item.Display(depth + 1);
    }
}

