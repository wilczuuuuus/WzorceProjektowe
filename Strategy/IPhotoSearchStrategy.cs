namespace StrategyPhotos;

public interface IPhotoSearchStrategy
{
    Task<List<string>> SearchAsync(string category);
}
