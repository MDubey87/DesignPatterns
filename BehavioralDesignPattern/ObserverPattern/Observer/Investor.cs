using ObserverPattern.Subject;

namespace ObserverPattern.Observer
{
    /// <summary>
    /// ConcreteObserver
    /// </summary>
    public class Investor : IObserver
    {

        private string _name;
        private ISubject _stockMarket;

        public Investor(string name, ISubject stockMarket)
        {
            _name = name;
            _stockMarket = stockMarket;
            _stockMarket.Attach(this);
        }

        public void Update()
        {
            Console.WriteLine($"{_name} received notification: Stock price changed.");
        }
    }
}
