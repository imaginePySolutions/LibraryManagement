using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryManagement.Core.BookManagement
{
    public interface IAuthorService
    {
        Task<List<Author>> GetAuthors();
    }
}