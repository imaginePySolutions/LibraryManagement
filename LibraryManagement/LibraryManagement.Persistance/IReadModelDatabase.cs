using System.Linq;
using LibraryManagement.Core.BookManagement;

namespace LibraryManagement.Persistance
{
    public interface IReadModelDatabase
    {
         IQueryable<Book> Books {get; }
         IQueryable<Author> Authors {get; }
    }
}