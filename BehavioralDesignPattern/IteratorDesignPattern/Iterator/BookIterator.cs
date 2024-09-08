using IteratorDesignPattern.Model;

namespace IteratorDesignPattern.Iterator
{
    public class BookIterator : IIterator<Book>
    {
        private readonly List<Book> _books;
        private int _position = 0;

        public BookIterator(List<Book> books)
        {
            _books = books;
        }

        public bool HasNext()
        {
            return _position < _books.Count;
        }

        public Book Next()
        {
            if (!HasNext())
            {
                return null;
            }

            return _books[_position++];
        }
    }
}
