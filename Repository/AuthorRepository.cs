using bookstore.Context;
using bookstore.Models;

namespace bookstore.Repository;

public class AuthorRepository : IAuthorRepository
{
    private readonly IDatabaseContext _context;

    public AuthorRepository(IDatabaseContext context)
    {
        _context = context;
    }

    public List<Author> GetAll()
    {
        return _context.Authors.ToList();
    }

    public Author Add(Author author)
    {
        _context.Authors.Add(author);
        _context.SaveChanges();
        return author;
    }

    public Author Update(Author author, int AuthorId)
    {
        Author? existingAuthor = _context.Authors
            .Find(AuthorId) ?? throw new Exception("Author not found");

        existingAuthor.Name = author.Name;
        _context.SaveChanges();
        return existingAuthor;
    }

    public void Delete(int AuthorId)
    {
        Author? existingAuthor = _context.Authors
            .Find(AuthorId) ?? throw new Exception("Author not found");

        _context.Authors.Remove(existingAuthor);
        _context.SaveChanges();
    }
}