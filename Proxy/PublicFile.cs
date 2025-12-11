namespace ProxyFile;

public class PublicFile : IFile
{
    public string Name { get; }
    private readonly string _content;

    public PublicFile(string name, string content)
    {
        Name = name;
        _content = content;
    }

    public string GetContent() => _content;
}

