using LibraryManagement.Core.BookManagement;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Persistance
{
    public class LibraryDbContext : DbContext
    {
      public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base((DbContextOptions)options)
      {

      }   

      public DbSet<Book> Books { get; set; }
      public DbSet<Author> Authors { get; set; }

     
    }
}