using Microsoft.EntityFrameworkCore;
namespace PublisherData;
using PublisherDomain;
public class PubContext : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost; Database=PubDatabase; User Id=sa; Password=Access@2023; Encrypt=False; TrustServerCertificate=True");
    }
}

