namespace ProxyFile;

public class FileProxy : IFile
{
    private readonly RestrictedFile _restrictedFile;
    private readonly string _password;

    public string Name => _restrictedFile.Name;

    public FileProxy(RestrictedFile restrictedFile, string password)
    {
        _restrictedFile = restrictedFile;
        _password = password;
    }

    public string GetContent()
    {
        throw new UnauthorizedAccessException("Access denied. Use GetContent with password.");
    }

    public string GetContent(string password)
    {
        if (password == _password)
            return _restrictedFile.GetContent();
        
        throw new UnauthorizedAccessException("Invalid password.");
    }

    public bool ValidatePassword(string password) => password == _password;
}

