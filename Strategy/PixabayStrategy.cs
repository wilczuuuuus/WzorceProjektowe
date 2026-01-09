namespace StrategyPhotos;

using System.Text.Json;

public class PixabayStrategy : IPhotoSearchStrategy
{
    private readonly HttpClient _client;
    private readonly string _apiKey;

    public PixabayStrategy(string apiKey)
    {
        _apiKey = apiKey;
        _client = new HttpClient();
    }

    public async Task<List<string>> SearchAsync(string category)
    {
        var response = await _client.GetAsync($"https://pixabay.com/api/?key={_apiKey}&q={category}&per_page=5");
        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadAsStringAsync();
        var doc = JsonDocument.Parse(json);

        var urls = new List<string>();
        foreach (var hit in doc.RootElement.GetProperty("hits").EnumerateArray())
        {
            urls.Add(hit.GetProperty("webformatURL").GetString()!);
        }

        return urls;
    }
}
