using IteratorDesignPattern.Aggregator;
using IteratorDesignPattern.Iterator;
using IteratorDesignPattern.Model;

BookCollection bookCollection = new BookCollection();
bookCollection.AddBook(new Book("Do Epic Shit", "Ankur Wariko"));
bookCollection.AddBook(new Book("To Kill a Mockingbird", "Harper Lee"));
bookCollection.AddBook(new Book("1984", "George Orwell"));

IIterator<Book> iterator = bookCollection.CreateIterator();

while (iterator.HasNext())
{
    Book book = iterator.Next();
    Console.WriteLine($"{book.Title} by {book.Author}");
}
Console.ReadLine();