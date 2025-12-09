namespace FactoryGarrison;

public abstract class Warrior
{
    public abstract string Profession { get; }
    
    public override string ToString()
    {
        return $"{Profession}";
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

