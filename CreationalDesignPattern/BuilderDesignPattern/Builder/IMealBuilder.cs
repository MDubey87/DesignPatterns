using BuilderDesignPattern.Product;

namespace BuilderDesignPattern.Builder
{
    /// <summary>
    /// Abstract interface defining the steps for building the object
    /// </summary>
    public interface IMealBuilder
    {
        void AddBurger(string burger);
        void AddDrink(string drink);
        void AddFries(string fries);
        void AddDessert(string dessert);
        Meal GetMeal();
    }
}