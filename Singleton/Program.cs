using SingletonVault;

var vault = Vault.Instance;

var key1 = vault.GetKey();
Console.WriteLine($"First attempt: {key1 ?? "Key already retrieved"}");

var key2 = vault.GetKey();
Console.WriteLine($"Second attempt: {key2 ?? "Key already retrieved"}");

