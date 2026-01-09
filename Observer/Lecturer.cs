namespace ObserverExam;

public class Lecturer
{
    private readonly Dictionary<IObserver, int> _results = new();

    public void AddStudent(IObserver student, int grade)
    {
        _results[student] = grade;
    }

    public void RemoveStudent(IObserver student)
    {
        _results.Remove(student);
    }

    public void AnnounceResults()
    {
        Console.WriteLine("Lecturer announces exam results:");
        foreach (var (student, grade) in _results)
            student.Update(grade);
    }
}
