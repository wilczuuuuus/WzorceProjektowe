namespace FacadeWeather;

public class WeatherData
{
    public string City { get; set; } = "";
    public double Temperature { get; set; }
    public string Description { get; set; } = "";
}

public class OpenWeatherResponse
{
    public MainData? Main { get; set; }
    public List<Weather>? Weather { get; set; }
    public string? Name { get; set; }
}

public class MainData
{
    public double Temp { get; set; }
}

public class Weather
{
    public string? Description { get; set; }
}

