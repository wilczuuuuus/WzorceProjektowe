namespace AdapterClub;

public class FakeAdult : Adult
{
    public FakeAdult(Person person) : base(person.Name) { }
}
