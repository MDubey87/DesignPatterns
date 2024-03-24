using ObserverPattern.Observer;

namespace ObserverPattern.Subject
{
    /// <summary>
    /// Subject Interface
    /// </summary>
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }
}
