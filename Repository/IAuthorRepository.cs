using bookstore.Models;

namespace bookstore.Repository;

public interface IAuthorRepository
{
    List<Author> GetAll();
    Author Add(Author author);
    Author Update(Author author, int AuthorId);
    void Delete(int AuthorId);
}