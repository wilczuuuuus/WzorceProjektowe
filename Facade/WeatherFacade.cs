using Newtonsoft.Json;

namespace FacadeWeather;

public class WeatherFacade
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;
    private const string BaseUrl = "https://api.openweathermap.org/data/2.5/weather";

    public WeatherFacade(string apiKey)
    {
        _httpClient = new HttpClient();
        _apiKey = apiKey;
    }

    public async Task<double> GetTemperatureAsync(string city)
    {
        var weather = await GetWeatherAsync(city);
        return weather.Temperature;
    }

    public async Task<WeatherData> GetWeatherAsync(string city)
    {
        var url = $"{BaseUrl}?q={city}&appid={_apiKey}&units=metric";
        
        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        
        var json = await response.Content.ReadAsStringAsync();
        var data = JsonConvert.DeserializeObject<OpenWeatherResponse>(json);

        return new WeatherData
        {
            City = data?.Name ?? city,
            Temperature = data?.Main?.Temp ?? 0,
            Description = data?.Weather?.FirstOrDefault()?.Description ?? ""
        };
    }
}

