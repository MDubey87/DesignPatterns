namespace IteratorDesignPattern.Iterator
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }
}
