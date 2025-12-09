using FactoryGarrison;

var garrison = new Garrison();

Warrior[] army = new Warrior[10];

for (int i = 0; i < 3; i++)
    army[i] = garrison.Train("infantry");

for (int i = 3; i < 6; i++)
    army[i] = garrison.Train("cavalry");

for (int i = 6; i < 10; i++)
    army[i] = garrison.Train("archer");

Console.WriteLine("Army composition:");
for (int i = 0; i < army.Length; i++)
    Console.WriteLine($"  [{i}] {army[i]}");

