namespace PrototypeOrk;

public class Ork
{
    public string Name { get; set; } = string.Empty;
    public int Strength { get; set; }
    public int Health { get; set; }

    public override string ToString()
    {
        return $"{Name} (Strength: {Strength}, Health: {Health})";
    }
}

