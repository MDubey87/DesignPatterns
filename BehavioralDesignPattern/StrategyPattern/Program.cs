// Create payment processor with a default strategy
using StrategyPattern.Context;
using StrategyPattern.Strategy;

var paymentProcessor = new PaymentProcessor(new CreditCardPaymentStrategy());

// Process payments using different strategies
paymentProcessor.ProcessPayment(100.0);
paymentProcessor.ChangePaymentStrategy(new PayPalPaymentStrategy());
paymentProcessor.ProcessPayment(50.0);
paymentProcessor.ChangePaymentStrategy(new BitcoinPaymentStrategy());
paymentProcessor.ProcessPayment(200.0);
Console.ReadLine();