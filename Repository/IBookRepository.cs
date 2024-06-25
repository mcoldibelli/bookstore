using bookstore.DTO;
using bookstore.Models;

namespace bookstore.Repository;

public interface IBookRepository
{
    List<BookDTO> GetAll();
    Book Add(Book book);
    Book Update(Book book, int BookId);
    void Delete(int BookId);
}