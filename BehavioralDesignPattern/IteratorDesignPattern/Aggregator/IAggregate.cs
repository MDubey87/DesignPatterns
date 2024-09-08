using IteratorDesignPattern.Iterator;

namespace IteratorDesignPattern.Aggregator
{
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
    }
}
