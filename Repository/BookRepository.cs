using bookstore.Context;
using bookstore.DTO;
using bookstore.Models;
using Microsoft.EntityFrameworkCore;

namespace bookstore.Repository;

public class BookRepository : IBookRepository
{
    private readonly IDatabaseContext _context;

    public BookRepository(IDatabaseContext context)
    {
        _context = context;
    }

    public List<BookDTO> GetAll()
    {
        // eager loading
        return _context.Books.Include(book => book.Author)
                            .Select(book => new BookDTO
                            {
                                BookName = book.Title,
                                AuthorName = book.Author!.Name
                            }).ToList();
    }

    public Book Add(Book book)
    {
        _context.Books.Add(book);
        _context.SaveChanges();
        return book;
    }

    public Book Update(Book book, int BookId)
    {
        Book? existingBook = _context.Books
            .Find(BookId) ?? throw new Exception("Book not found");

        existingBook.Title = book.Title;
        existingBook.AuthorId = book.AuthorId;
        _context.SaveChanges();
        return existingBook;
    }

    public void Delete(int BookId)
    {
        Book? existingBook = _context.Books
            .Find(BookId) ?? throw new Exception("Book not found");

        _context.Books.Remove(existingBook);
        _context.SaveChanges();
    }
}