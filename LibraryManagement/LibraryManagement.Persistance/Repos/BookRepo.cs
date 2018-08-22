using System.Threading.Tasks;
using LibraryManagement.Core.BookManagement;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Persistance.Repos
{
    public class BookRepo : RepositoryBase<Book>, IBookRepo
    {
        private readonly LibraryDbContext _context;
        public BookRepo(LibraryDbContext context) : base(context)
        {
            _context = context;

        }

        public override Task<Book> GetAllAysnc(object id)
        {
            throw new System.NotImplementedException();
        }

        public override Task<Book> GetAsync(object id)
        {
            return _context.Books.SingleOrDefaultAsync(bo => bo.Id == (int)id);
        }
    }
}