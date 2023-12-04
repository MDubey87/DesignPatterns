using FactoryMethodDesignPatternDemo.Factory;
using FactoryMethodDesignPatternDemo.Product;
//CoffeeFactory createBeverage method will return an instance of Coffee Product
IBeverage coffee =new CoffeeFactory().createBeverage();
if (coffee != null)
{
    Console.WriteLine(coffee.Serve());
}
Console.WriteLine("--------------------------------");
//TeaFactory createBeverage method will return an instance of Tea Product
IBeverage tea = new TeaFactory().createBeverage();
if (tea != null)
{
    Console.WriteLine(tea.Serve());
}
Console.ReadLine();

