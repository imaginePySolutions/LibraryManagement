using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryManagement.Core
{
    public interface IRepositoryBase<T> where T : class
    {
         Task<T> GetAsync(object id);
         Task<T> GetAllAysnc(object id);
         void Add(T entity);
         void Add(IEnumerable<T> entities);
         void Delete(T entity);
         void Delete(IEnumerable<T> entities);

    }
}