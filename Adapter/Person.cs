namespace AdapterClub;

public class Person
{
    public string Name { get; }

    public Person(string name)
    {
        Name = name;
    }

    public virtual bool IsAdult() => false;
}
