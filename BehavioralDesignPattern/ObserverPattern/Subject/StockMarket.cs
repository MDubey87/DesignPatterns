using ObserverPattern.Observer;

namespace ObserverPattern.Subject
{
    /// <summary>
    /// ConcreteSubject
    /// </summary>
    public class StockMarket : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private decimal _stockPrice;

        public decimal StockPrice
        {
            get { return _stockPrice; }
            set
            {
                _stockPrice = value;
                // Investors will be notified of the updated price change
                Notify();
            }
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
