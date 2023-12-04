using FactoryDesignPatternDemo.Factory;
using FactoryDesignPatternDemo.Product;

IBeverage beverage = BeverageFactory.GetBeverage("Coffee");
if (beverage != null)
{
    Console.WriteLine(beverage.Serve());
    Console.WriteLine("Press any key...");
    Console.ReadLine();
}