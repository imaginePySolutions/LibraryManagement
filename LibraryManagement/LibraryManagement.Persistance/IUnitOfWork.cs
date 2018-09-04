using System.Threading.Tasks;

namespace LibraryManagement.Persistance
{
    public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}