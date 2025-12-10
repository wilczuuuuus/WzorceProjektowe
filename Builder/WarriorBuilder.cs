namespace BuilderGarrison;

public abstract class WarriorBuilder
{
    protected Warrior? Warrior;

    public abstract void JoinArmy();
    public abstract void GetWeapon();
    public abstract void Train();

    public IWarrior GetWarrior()
    {
        return Warrior ?? throw new InvalidOperationException("Warrior not created");
    }
}

public class PiechurBuilder : WarriorBuilder
{
    public override void JoinArmy()
    {
        Warrior = new Infantry();
    }

    public override void GetWeapon()
    {
        Warrior!.Weapon = "Sword";
    }

    public override void Train()
    {
        Warrior!.IsTrained = true;
    }
}

public class StrzelecBuilder : WarriorBuilder
{
    public override void JoinArmy()
    {
        Warrior = new Archer();
    }

    public override void GetWeapon()
    {
        Warrior!.Weapon = "Bow";
    }

    public override void Train()
    {
        Warrior!.IsTrained = true;
    }
}

public class KonnyBuilder : WarriorBuilder
{
    public override void JoinArmy()
    {
        Warrior = new Cavalry();
    }

    public override void GetWeapon()
    {
        Warrior!.Weapon = "Lance";
    }

    public override void Train()
    {
        Warrior!.IsTrained = true;
    }
}

