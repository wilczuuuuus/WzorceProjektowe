var cache = new Dictionary<string, (string Name, byte[] Data)>(StringComparer.OrdinalIgnoreCase);
var texturesDir = Path.Combine(AppContext.BaseDirectory, "Textures");

(string Name, byte[] Data) GetTexture(string path)
{
    if (cache.TryGetValue(path, out var tex))
        return tex;

    tex = (Path.GetFileName(path), File.ReadAllBytes(path));
    cache[path] = tex;
    Console.WriteLine($"Load: {tex.Name}");
    return tex;
}

var grass = GetTexture(Path.Combine(texturesDir, "grass.txt"));
var hero = GetTexture(Path.Combine(texturesDir, "hero.txt"));
var stone = GetTexture(Path.Combine(texturesDir, "stone.txt"));

var objects = new[]
{
    new { Name = "Hero", Texture = hero },
    new { Name = "Tree", Texture = grass },
    new { Name = "Large Tree", Texture = grass },
    new { Name = "Rock", Texture = stone },
    new { Name = "Stone", Texture = stone },
    new { Name = "New Hero", Texture = hero },
};

Console.WriteLine();
foreach (var o in objects)
    Console.WriteLine($"{o.Name} {o.Texture.Name}");

Console.WriteLine();
Console.WriteLine($"Cached: {cache.Count}");

