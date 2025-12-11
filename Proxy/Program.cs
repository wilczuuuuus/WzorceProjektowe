using ProxyFile;

var publicFiles = new List<PublicFile>
{
    new PublicFile("public_file1.txt", "Hello !"),
    new PublicFile("public_file2.txt", "This si public")
};

var restrictedProxies = new List<FileProxy>
{
    new FileProxy(new RestrictedFile("salary_info.txt", "big salary"), "test123"),
    new FileProxy(new RestrictedFile("protected_info.txt", "test"), "test123")
};

while (true)
{
    Console.WriteLine("Public:");
    for (int i = 0; i < publicFiles.Count; i++)
        Console.WriteLine($"{i + 1}. {publicFiles[i].Name}");
    
    Console.WriteLine("Restricted:");
    for (int i = 0; i < restrictedProxies.Count; i++)
        Console.WriteLine($"{publicFiles.Count + i + 1}. {restrictedProxies[i].Name}");
    
    Console.WriteLine("0. Exit");
    
    var input = Console.ReadLine();
    
    if (!int.TryParse(input, out int choice) || choice == 0)
        break;
    
    if (choice >= 1 && choice <= publicFiles.Count)
    {
        var file = publicFiles[choice - 1];
        Console.WriteLine(file.GetContent());
    }
    else if (choice <= publicFiles.Count + restrictedProxies.Count)
    {
        var proxy = restrictedProxies[choice - publicFiles.Count - 1];
        Console.Write("Password: ");
        var password = Console.ReadLine() ?? "";
        
        try
        {
            Console.WriteLine(proxy.GetContent(password));
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Access denied");
        }
    }
}
