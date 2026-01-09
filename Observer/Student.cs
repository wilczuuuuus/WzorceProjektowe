namespace ObserverExam;

public class Student : IObserver
{
    public string Name { get; }

    public Student(string name)
    {
        Name = name;
    }

    public void Update(int grade)
    {
        Console.WriteLine($"{Name} received grade: {grade}");
    }
}
