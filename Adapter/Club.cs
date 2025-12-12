namespace AdapterClub;

public class Club
{
    public void TryEnter(Person person)
    {
        if (person.IsAdult())
            Console.WriteLine($"{person.Name} entered the club!");
        else
            Console.WriteLine($"{person.Name} was stopped by the bouncer.");
    }
}
