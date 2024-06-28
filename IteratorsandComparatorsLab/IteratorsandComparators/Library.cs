using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsandComparators;

public class Library : IEnumerable<Book>
{
    List<Book> books;
    public Library(params Book[] books)
    {
        this.books = books.ToList();
        this.books.Sort();
    }

    public IEnumerator<Book> GetEnumerator()
    {
        return new BooksEnumerator(books);
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
public class BooksEnumerator : IEnumerator<Book>
{
    private List<Book> books;
    private int index = -1;

    public BooksEnumerator(List<Book> books)
    {
        this.books = books;
    }
    public Book Current => books[index];

    object IEnumerator.Current => Current;

    public void Dispose()
    {
       
    }

    public bool MoveNext()
    {
        index++;
        return index < books.Count;
    }

    public void Reset()
    {
        
    }
}
