namespace AdapterClub;

public class Adult : Person
{
    public Adult(string name) : base(name) { }

    public override bool IsAdult() => true;
}
