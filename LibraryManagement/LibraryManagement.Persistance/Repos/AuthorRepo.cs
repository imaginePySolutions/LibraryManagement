using System.Threading.Tasks;
using LibraryManagement.Core.BookManagement;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Persistance.Repos
{
    public class AuthorRepo : RepositoryBase<Author>, IAuthorRepo
    {
        private readonly LibraryDbContext _context;
        public AuthorRepo(LibraryDbContext context) : base(context)
        {
            _context = context;

        }

        public override Task<Author> GetAllAysnc(object id)
        {
            throw new System.NotImplementedException();
        }

        public override Task<Author> GetAsync(object id)
        {
            return _context.Authors.SingleOrDefaultAsync(ah => ah.Id == (int)id);
        }
    }
}