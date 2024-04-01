namespace StrategyPattern.Strategy
{
    /// <summary>
    /// Define the strategy interface
    /// </summary>
    public interface IPaymentStrategy
    {
        void ProcessPayment(double amount);
    }
}
