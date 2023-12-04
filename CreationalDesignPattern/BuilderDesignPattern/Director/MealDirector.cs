using BuilderDesignPattern.Builder;
using BuilderDesignPattern.Product;

namespace BuilderDesignPattern.Director
{
    /// <summary>
    /// Manages the building process using the Builder
    /// </summary>
    public class MealDirector
    {
        public Meal Construct(IMealBuilder builder)
        {
            builder.AddBurger("Cheeseburger");
            builder.AddDrink("Cola");
            builder.AddFries("Large fries");
            builder.AddDessert("Ice cream");

            return builder.GetMeal();
        }
    }
}
