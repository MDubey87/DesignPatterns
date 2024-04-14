using TemplateMethodPattern;

Recipe pizza = new PizzaRecipe();
Recipe pasta = new PastaRecipe();

Console.WriteLine("Making Pizza:");
pizza.MakeRecipe();

Console.WriteLine("\nMaking Pasta:");
pasta.MakeRecipe();
Console.ReadLine();
