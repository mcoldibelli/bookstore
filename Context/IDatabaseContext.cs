using bookstore.Models;
using Microsoft.EntityFrameworkCore;

namespace bookstore.Context;

public interface IDatabaseContext
{
    public DbSet<Author> Authors { get; set; }
    public int SaveChanges();
}