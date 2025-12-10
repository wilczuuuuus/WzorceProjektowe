namespace BuilderGarrison;

public abstract class Warrior : IWarrior
{
    public abstract string Profession { get; }
    public string Weapon { get; set; } = string.Empty;
    public bool IsTrained { get; set; }

    public override string ToString()
    {
        return $"{Profession} (Weapon: {Weapon}, Trained: {IsTrained})";
    }
}

public class Infantry : Warrior
{
    public override string Profession => "Infantry";
}

public class Archer : Warrior
{
    public override string Profession => "Archer";
}

public class Cavalry : Warrior
{
    public override string Profession => "Cavalry";
}

