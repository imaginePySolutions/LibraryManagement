using System.Collections.Generic;
using System.Threading.Tasks;
using LibraryManagement.Core;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Persistance
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly DbSet<T> _dbSet;
        protected RepositoryBase(DbContext context)
        {
            _dbSet = context.Set<T>();

        }

        public async void Add(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async void Add(IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public  void Delete(T entity)
        {
             _dbSet.Remove(entity);
        }

        public void Delete(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public abstract Task<T> GetAllAysnc(object id);
        

        public abstract Task<T> GetAsync(object id);
        
    }
}