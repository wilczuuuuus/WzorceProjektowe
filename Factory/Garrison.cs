namespace FactoryGarrison;

public class Garrison
{
    public Warrior Train(string profession)
    {
        return profession.ToLower() switch
        {
            "infantry" => new Infantry(),
            "archer" => new Archer(),
            "cavalry" => new Cavalry(),
            _ => throw new ArgumentException($"Unknown profession: {profession}")
        };
    }
}

