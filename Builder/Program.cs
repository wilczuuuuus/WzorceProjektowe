using BuilderGarrison;

var garrison = new Garrison();
var army = new List<IWarrior>();

var piechurBuilder = new PiechurBuilder();
var strzelecBuilder = new StrzelecBuilder();
var konnyBuilder = new KonnyBuilder();

for (int i = 0; i < 2; i++)
{
    garrison.SetBuilder(piechurBuilder);
    garrison.TrainWarrior();
    army.Add(piechurBuilder.GetWarrior());
}

for (int i = 0; i < 2; i++)
{
    garrison.SetBuilder(konnyBuilder);
    garrison.TrainWarrior();
    army.Add(konnyBuilder.GetWarrior());
}

for (int i = 0; i < 2; i++)
{
    garrison.SetBuilder(strzelecBuilder);
    garrison.TrainWarrior();
    army.Add(strzelecBuilder.GetWarrior());
}

Console.WriteLine("Army composition:");
for (int i = 0; i < army.Count; i++)
    Console.WriteLine($"  [{i}] {army[i]}");

