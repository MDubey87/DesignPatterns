namespace MementoPattern
{
    /// <summary>
    /// Originator class that uses Memento to save and restore state
    /// </summary>
    public class Originator
    {
        public string State { get; set; }

        public void SetState(string state)
        {
            Console.WriteLine($"Setting state to: {state}");
            State = state;
        }

        public Memento SaveStateToMemento()
        {
            Console.WriteLine("Saving state to Memento.");
            return new Memento(State);
        }

        public void RestoreStateFromMemento(Memento memento)
        {
            State = memento.State;
            Console.WriteLine($"Restored state from Memento: {State}");
        }
    }
}
