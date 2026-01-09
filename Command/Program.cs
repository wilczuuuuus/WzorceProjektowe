using CommandSanta;

var factory = new SantaClausFactory();
var helper = new Helper();

helper.AddCommand(new ProduceToyCommand(factory, "Teddy Bear"));
helper.AddCommand(new ProduceToyCommand(factory, "Lego Set"));
helper.AddCommand(new ProduceToyCommand(factory, "Doll"));
helper.AddCommand(new ProduceRodCommand(factory));

Console.WriteLine("Santa's Helper executes commands:");
helper.ExecuteCommands();
