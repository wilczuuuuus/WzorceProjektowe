using Newtonsoft.Json;
using PrototypeOrk;

var originalOrk = new Ork
{
    Name = "Grom",
    Strength = 100,
    Health = 200
};

Console.WriteLine($"Original: {originalOrk}");
Console.WriteLine();

var clones = new List<Ork>();
var random = new Random();

for (int i = 0; i < 5; i++)
{
    var json = JsonConvert.SerializeObject(originalOrk);
    var clone = JsonConvert.DeserializeObject<Ork>(json)!;
    
    clone.Name = $"Clone_{i + 1}";
    clone.Strength = random.Next(50, 150);
    
    clones.Add(clone);
}

Console.WriteLine("Clones:");
for (int i = 0; i < clones.Count; i++)
    Console.WriteLine($"  [{i}] {clones[i]}");

