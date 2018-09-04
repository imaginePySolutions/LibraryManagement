using System.Linq;
using LibraryManagement.Core.BookManagement;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Persistance
{
    public class ReadModelDatabase : IReadModelDatabase
    {
        private readonly LibraryDbContext _context;

        public ReadModelDatabase(LibraryDbContext context)
        {
            _context = context;
        }
        public IQueryable<Book> Books => _context.Books.AsNoTracking();

        public IQueryable<Author> Authors => _context.Authors.AsNoTracking();
    }
}