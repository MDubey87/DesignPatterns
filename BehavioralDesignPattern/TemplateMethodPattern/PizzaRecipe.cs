namespace TemplateMethodPattern
{
    /// <summary>
    /// Concrete class implementing the PizzaRecipe
    /// </summary>
    public class PizzaRecipe : Recipe
    {
        protected override void PrepareIngredients()
        {
            Console.WriteLine("Prepare pizza dough, sauce, cheese, and toppings.");
        }

        protected override void Cook()
        {
            Console.WriteLine("Bake the pizza in the oven.");
        }
    }
}
