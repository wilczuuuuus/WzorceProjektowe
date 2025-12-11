using FacadeWeather;

var apiKey = Environment.GetEnvironmentVariable("OPENWEATHER_API_KEY") ?? "demo_key";
var facade = new WeatherFacade(apiKey);

var cities = new[] { "Warsaw", "Krakow", "Gdansk" };

while (true)
{
    Console.WriteLine("Select city:");
    for (int i = 0; i < cities.Length; i++)
        Console.WriteLine($"{i + 1}. {cities[i]}");
    Console.WriteLine("0. Exit");
    
    var input = Console.ReadLine();
    
    if (!int.TryParse(input, out int choice) || choice == 0)
        break;
    
    if (choice < 1 || choice > cities.Length)
        continue;
    
    var city = cities[choice - 1];
    
    try
    {
        var temperature = await facade.GetTemperatureAsync(city);
        Console.WriteLine($"{city}: {temperature}C");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}
