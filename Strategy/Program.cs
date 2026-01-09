using StrategyPhotos;

var pexelsKey = Environment.GetEnvironmentVariable("PEXELS_API_KEY") ?? "demo_key";
var pixabayKey = Environment.GetEnvironmentVariable("PIXABAY_API_KEY") ?? "demo_key";

var pexels = new PexelsStrategy(pexelsKey);
var pixabay = new PixabayStrategy(pixabayKey);
var searcher = new PhotoSearcher(pexels);

while (true)
{
    Console.WriteLine("\nSelect photo database:");
    Console.WriteLine("1. Pexels");
    Console.WriteLine("2. Pixabay");
    Console.WriteLine("0. Exit");

    var choice = Console.ReadLine();

    if (choice == "0" || choice == null)
        break;

    searcher.SetStrategy(choice == "1" ? pexels : pixabay);

    Console.Write("Enter category: ");
    var category = Console.ReadLine();

    if (string.IsNullOrEmpty(category))
        continue;

    try
    {
        var photos = await searcher.SearchPhotosAsync(category);
        Console.WriteLine($"\nFound {photos.Count} photos:");
        foreach (var url in photos)
            Console.WriteLine(url);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}
