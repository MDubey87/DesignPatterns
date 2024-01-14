using ProxyPattern.RealSubject;
using ProxyPattern.Subject;

namespace ProxyPattern.Proxy
{
    /// <summary>
    /// Proxy Class
    /// </summary>
    public class Proxy
    {
        private IPrice _price;
        public double GetCurrentGoldPrice(bool isCurrentPrice)
        {
            if (isCurrentPrice)
            {
                _price = new GoldPrice();
                // Get the actual price
                return _price.GetPrice();
            }
            return 0;
        }
    }
}
