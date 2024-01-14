using ProxyPattern.Subject;

namespace ProxyPattern.RealSubject
{
    /// <summary>
    /// RealSubject class that implements the IPrice interface
    /// </summary>
    public class GoldPrice : IPrice
    {
        int minimum = 999;
        int maximum = 9999;
        public double GetPrice()
        {
            Random rnd = new Random();
            return rnd.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
