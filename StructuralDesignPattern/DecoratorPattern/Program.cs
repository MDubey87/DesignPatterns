// Create a base coffee
using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

IBeverage coffee = new Coffee();

// Decorate the coffee with milk
coffee = new MilkDecorator(coffee);

// Decorate the coffee further with sugar
coffee = new SugarDecorator(coffee);

// Output the description and cost of the final beverage
Console.WriteLine($"Description: {coffee.GetDescription()}");
Console.WriteLine($"Cost: ${coffee.Cost()}");
Console.ReadLine();
