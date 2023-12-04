namespace BuilderDesignPattern.Product
{
    /// <summary>
    /// Represents the object that is being constructed
    /// </summary>
    public class Meal
    {
        public string Burger { get; set; }
        public string Drink { get; set; }
        public string Fries { get; set; }
        public string Dessert { get; set; }

        public void Display()
        {
            Console.WriteLine($"Burger: {Burger}, Drink: {Drink}, Fries: {Fries}, Dessert: {Dessert}");
        }
    }
}
