using System.Collections.Generic;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Abstractions
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetByIdAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task AddAsync(TEntity entity);
        void Remove(TEntity entity);
    }
}
