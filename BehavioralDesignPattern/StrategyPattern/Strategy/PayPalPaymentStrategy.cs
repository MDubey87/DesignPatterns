namespace StrategyPattern.Strategy
{
    /// <summary>
    /// Implement concrete strategies
    /// </summary>
    public class PayPalPaymentStrategy : IPaymentStrategy
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing PayPal payment of ${amount}");
            // Logic to process PayPal payment
        }
    }
}
