using System.Threading.Tasks;
using LibraryManagement.Core.ErrorHandling;

namespace LibraryManagement.Core.BookManagement
{
    public interface IBookService
    {
         Task NewBook(string name,int authorId);
    }
}