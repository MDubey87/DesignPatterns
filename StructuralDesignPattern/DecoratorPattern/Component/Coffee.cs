namespace DecoratorPattern.Component
{
    /// <summary>
    /// Concrete component representing a basic beverag
    /// </summary>
    public class Coffee : IBeverage
    {
        public string GetDescription()
        {
            return "Coffee";
        }

        public double Cost()
        {
            return 5.0;
        }
    }
}
