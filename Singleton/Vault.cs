namespace SingletonVault;

public class Vault
{
    private static Vault? _instance;
    private static readonly object _lock = new object();
    
    private readonly string _key;
    private bool _keyRetrieved;

    private Vault()
    {
        _key = Guid.NewGuid().ToString();
        _keyRetrieved = false;
    }

    public static Vault Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Vault();
                }
                return _instance;
            }
        }
    }

    public string? GetKey()
    {
        if (_keyRetrieved)
        {
            return null;
        }
        
        _keyRetrieved = true;
        return _key;
    }
}

