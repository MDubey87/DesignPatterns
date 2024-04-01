namespace StrategyPattern.Strategy
{
    public class BitcoinPaymentStrategy : IPaymentStrategy
    {
        /// <summary>
        /// Implement concrete strategies
        /// </summary>
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing Bitcoin payment of ${amount}");
            // Logic to process Bitcoin payment
        }
    }
}