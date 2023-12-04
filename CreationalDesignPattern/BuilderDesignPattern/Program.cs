// See https://aka.ms/new-console-template for more information
using BuilderDesignPattern.Builder;
using BuilderDesignPattern.Director;
using BuilderDesignPattern.Product;

MealDirector director = new MealDirector();
IMealBuilder builder = new ConcreteMealBuilder();

Meal meal = director.Construct(builder);
meal.Display();
Console.ReadKey();

