namespace TemplateMethodPattern
{
    /// <summary>
    /// Concrete class implementing the PastaRecipe
    /// </summary>
    public class PastaRecipe : Recipe
    {
        protected override void PrepareIngredients()
        {
            Console.WriteLine("Boil pasta and prepare sauce.");
        }

        protected override void Cook()
        {
            Console.WriteLine("Combine cooked pasta with sauce.");
        }
    }
}
