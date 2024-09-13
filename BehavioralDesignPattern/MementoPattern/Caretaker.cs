namespace MementoPattern
{
    /// <summary>
    /// Caretaker class that manages Mementos
    /// </summary>
    public class Caretaker
    {
        private List<Memento> _mementoList = new List<Memento>();

        public void AddMemento(Memento memento)
        {
            _mementoList.Add(memento);
            Console.WriteLine("State saved to Caretaker.");
        }

        public Memento GetMemento(int index)
        {
            return _mementoList[index];
        }
    }
}
