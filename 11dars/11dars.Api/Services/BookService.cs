using _11dars.Api.Models;

namespace _11dars.Api.Services;

public class BookService
{
    private List<Book> books;

    public BookService()
    {
        books = new List<Book>();
    }

    public Book GetById(Guid id)
    {
        foreach (var book in books)
        {
            if(book.Id == id)
            {
                return book;
            }
        }

        return null;
    }

    private bool CheckBooks()
    {
        if(books == null || books.Count == 0)
        {
            return false;
        }

        return true;
    }

    public Book GetExpensiveBook()
    {
        if(CheckBooks() is false)
        {
            return null;
        }

        var mostExpensiveBook = new Book(); 

        foreach (var book in books)
        {
            if(mostExpensiveBook.Price <  book.Price)
            {
                mostExpensiveBook = book;
            }
        }

        return mostExpensiveBook;
    }

    public Book GetMostPagedBook()
    {
        if (CheckBooks() is false)
        {
            return null;
        }

        var mostPagedBook = new Book();

        foreach (var book in books)
        {
            if (mostPagedBook.PageNumber < book.PageNumber)
            {
                mostPagedBook = book;
            }
        }

        return mostPagedBook;
    }

    public Book GetMostReadBook()
    {
        if (CheckBooks() is false)
        {
            return null;
        }

        var mostReadBook = new Book();

        foreach (var book in books)
        {
            if (mostReadBook.ReadersName.Count < book.ReadersName.Count)
            {
                mostReadBook = book;
            }
        }

        return mostReadBook;
    }

    public List<Book> GetBooksByReaderName(string name)
    {
        if (CheckBooks() is false)
        {
            return null;
        }

        var booksByReaderName = new List<Book>();

        foreach (var book in books)
        {
            if(book.ReadersName.Contains(name) is true)
            {
                booksByReaderName.Add(book);
            }
        }

        return booksByReaderName;
    }

    public List<Book> GetBooksByAuthorName(string name)
    {
        if (CheckBooks() is false)
        {
            return null;
        }

        var booksByAuthorName = new List<Book>();

        foreach (var book in books)
        {
            if (book.AuthorsName.Contains(name) is true)
            {
                booksByAuthorName.Add(book);
            }
        }

        return booksByAuthorName;
    }

    public bool AddReaderToBook(Guid bookId, string readerName)
    {
        var book = GetById(bookId);

        if(book == null)
        {
            return false;
        }

        var index = books.IndexOf(book);
        books[index].ReadersName.Add(readerName);

        return true;
    }

    public bool AddAuthorToBook(Guid bookId, string authorName)
    {
        var book = GetById(bookId);

        if (book == null)
        {
            return false;
        }

        var index = books.IndexOf(book);
        books[index].AuthorsName.Add(authorName);

        return true;
    }
}
