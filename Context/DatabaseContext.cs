using bookstore.Models;
using Microsoft.EntityFrameworkCore;

namespace bookstore.Context;

public class DatabaseContext : DbContext, IDatabaseContext
{
    public DbSet<Author> Authors { get; set; } = null!;
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Server=localhost;Database=BookStore;User=SA;Password=SqlServer123!;TrustServerCertificate=True";
        optionsBuilder.UseSqlServer(connectionString);
    }
}