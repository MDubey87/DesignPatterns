using ProxyPattern.Proxy;
using ProxyPattern.RealSubject;

// Initiate the proxy class
Proxy _proxy = new Proxy();
// Call the proxy function
var goldPrice = _proxy.GetCurrentGoldPrice(true);
if (goldPrice > 0)
    Console.WriteLine("Current Gold price is :{0}", goldPrice);
else
    Console.WriteLine("No call to Api");
Console.WriteLine(Environment.NewLine);
goldPrice = _proxy.GetCurrentGoldPrice(false);
if (goldPrice > 0)
    Console.WriteLine("Current Gold price is :{0}", goldPrice);
else
    Console.WriteLine("No call to Api");
Console.ReadLine();