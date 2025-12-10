namespace BuilderGarrison;

public class Garrison
{
    private WarriorBuilder? _builder;

    public void SetBuilder(WarriorBuilder builder)
    {
        _builder = builder;
    }

    public void TrainWarrior()
    {
        _builder!.JoinArmy();
        _builder.GetWeapon();
        _builder.Train();
    }
}

