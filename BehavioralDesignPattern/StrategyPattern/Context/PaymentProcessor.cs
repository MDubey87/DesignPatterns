using StrategyPattern.Strategy;

namespace StrategyPattern.Context
{
    /// <summary>
    /// Implement the context
    /// </summary>
    public class PaymentProcessor
    {
        private IPaymentStrategy _paymentStrategy;

        public PaymentProcessor(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void ProcessPayment(double amount)
        {
            _paymentStrategy.ProcessPayment(amount);
        }

        // Method to dynamically change the payment strategy
        public void ChangePaymentStrategy(IPaymentStrategy newPaymentStrategy)
        {
            _paymentStrategy = newPaymentStrategy;
        }
    }
}
