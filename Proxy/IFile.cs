namespace ProxyFile;

public interface IFile
{
    string Name { get; }
    string GetContent();
}

