using System.Linq.Expressions;

namespace RAFWEB2.Domain.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> CreateAsync(T entity);

        Task<IEnumerable<T>> CreateRangeAsync(IEnumerable<T> entities);

        Task<T> UpdateAsync(T entity);

        Task UpdateRangeAsync(IEnumerable<T> entities);

        Task<T> RemoveAsync(T entity);

        Task<List<T>> GetAll();

        Task<int> RemoveRangeAsync(IEnumerable<T> entities);

        Task<T> GetByAsync(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] includes);

        IQueryable<T> GetAllQueryable();
    }
}
