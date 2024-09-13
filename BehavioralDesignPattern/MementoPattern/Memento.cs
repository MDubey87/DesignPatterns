namespace MementoPattern
{
    /// <summary>
    /// Memento class to hold the state
    /// </summary>
    public class Memento
    {
        public string State { get; private set; }

        public Memento(string state)
        {
            State = state;
        }
    }
}
