namespace StrategyPhotos;

public class PhotoSearcher
{
    private IPhotoSearchStrategy _strategy;

    public PhotoSearcher(IPhotoSearchStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(IPhotoSearchStrategy strategy)
    {
        _strategy = strategy;
    }

    public async Task<List<string>> SearchPhotosAsync(string category)
    {
        return await _strategy.SearchAsync(category);
    }
}
