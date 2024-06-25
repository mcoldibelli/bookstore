using bookstore.Models;
using Microsoft.EntityFrameworkCore;

namespace bookstore.Context;

public class DatabaseContext : DbContext, IDatabaseContext
{
    public DbSet<Author> Authors { get; set; } = null!;
    public DbSet<Book> Books { get; set; } = null!;

    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Server=localhost;Database=BookStore;User=SA;Password=SqlServer123!;TrustServerCertificate=True";
        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>()
                    .HasMany(author => author.Books)
                    .WithOne(book => book.Author)
                    .HasForeignKey(book => book.AuthorId);
    }
}