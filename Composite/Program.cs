using CompositeMenu;

var menu = new Category("Menu");

var appetizers = new Category("First Dish");
appetizers.Add(new Dish("Soup"));
appetizers.Add(new Dish("Salad"));
appetizers.Add(new Dish("Eggs"));

var mainCourses = new Category("Second Dish");

var meat = new Category("Meat");
meat.Add(new Dish("Chicken"));
meat.Add(new Dish("Chicken 2"));

var fish = new Category("Fish");
fish.Add(new Dish("Salmon"));
fish.Add(new Dish("Tuna"));

mainCourses.Add(meat);
mainCourses.Add(fish);
mainCourses.Add(new Dish("Pasta"));

var desserts = new Category("Dessert");
desserts.Add(new Dish("Cake 1"));
desserts.Add(new Dish("Cake"));

menu.Add(appetizers);
menu.Add(mainCourses);
menu.Add(desserts);

Console.WriteLine("Menu:");
menu.Display();

