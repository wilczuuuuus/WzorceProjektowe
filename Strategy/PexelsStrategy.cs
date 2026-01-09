namespace StrategyPhotos;

using System.Text.Json;

public class PexelsStrategy : IPhotoSearchStrategy
{
    private readonly HttpClient _client;
    private readonly string _apiKey;

    public PexelsStrategy(string apiKey)
    {
        _apiKey = apiKey;
        _client = new HttpClient();
        _client.DefaultRequestHeaders.Add("Authorization", _apiKey);
    }

    public async Task<List<string>> SearchAsync(string category)
    {
        var response = await _client.GetAsync($"https://api.pexels.com/v1/search?query={category}&per_page=5");
        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadAsStringAsync();
        var doc = JsonDocument.Parse(json);

        var urls = new List<string>();
        foreach (var photo in doc.RootElement.GetProperty("photos").EnumerateArray())
        {
            urls.Add(photo.GetProperty("src").GetProperty("medium").GetString()!);
        }

        return urls;
    }
}
