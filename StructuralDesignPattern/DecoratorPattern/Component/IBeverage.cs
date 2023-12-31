namespace DecoratorPattern.Component
{
    /// <summary>
    /// Interface for beverage
    /// </summary>
    public interface IBeverage
    {
        string GetDescription();
        double Cost();
    }
}
