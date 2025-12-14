namespace CompositeMenu;

public interface IMenuItem
{
    string Name { get; }
    void Display(int depth = 0);
}


