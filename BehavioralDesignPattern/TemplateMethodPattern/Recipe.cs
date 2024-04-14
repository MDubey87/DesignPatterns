namespace TemplateMethodPattern
{
    /// <summary>
    /// Abstract class defining the template method
    /// </summary>
    public abstract class Recipe
    {
        // Template method defining the algorithm
        public void MakeRecipe()
        {
            PrepareIngredients();
            Cook();
            Serve();
        }

        // Abstract methods to be implemented by subclasses
        protected abstract void PrepareIngredients();
        protected abstract void Cook();

        // Common method
        protected void Serve()
        {
            Console.WriteLine("Serve the dish.");
        }
    }
}
