using ObserverPattern.Observer;
using ObserverPattern.Subject;

StockMarket stockMarket = new StockMarket();
Investor investor1 = new Investor("John", stockMarket);
Investor investor2 = new Investor("Alice", stockMarket);

// Investors will be notified of the price change
stockMarket.StockPrice = 100;
Console.ReadLine();