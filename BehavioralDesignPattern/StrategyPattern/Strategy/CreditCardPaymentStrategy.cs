namespace StrategyPattern.Strategy
{
    /// <summary>
    /// Implement concrete strategies
    /// </summary>
    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing credit card payment of ${amount}");
            // Logic to process credit card payment
        }
    }
}
