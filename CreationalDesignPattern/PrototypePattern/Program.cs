using PrototypePattern.ConcretePrototype;
using PrototypePattern.Prototype;
using PrototypePattern.PrototypeManager;

// Create a prototype manager and add some prototype objects
CarPrototypeManager manager = new CarPrototypeManager();
manager.AddPrototype("Sedan", new Sedan { Model = "Toyota Camry", Color = "White", Price = 30000 });
manager.AddPrototype("SUV", new Suv { Model = "Ford Explorer", Color = "Black", Price = 40000 });

// Create a new sedan object by cloning the prototype and changing the color
ICar sedan = manager.GetPrototype("Sedan");
sedan.Color = "Red";

// Create a new SUV object by cloning the prototype and changing the model and price
ICar suv = manager.GetPrototype("SUV");
suv.Model = "Honda CR-V";
suv.Price = 35000;

// Display the properties of the new objects
Console.WriteLine("Sedan: Model = {0}, Color = {1}, Price = {2}", sedan.Model, sedan.Color, sedan.Price);
Console.WriteLine("SUV: Model = {0}, Color = {1}, Price = {2}", suv.Model, suv.Color, suv.Price);
Console.ReadKey();
