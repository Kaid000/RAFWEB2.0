using Microsoft.EntityFrameworkCore;
using RAFWEB2.Core.Context;
using RAFWEB2.Domain.Repositories.Interfaces;
using System.Linq.Expressions;

namespace RAFWEB2.Domain.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly ApplicationContext _db;
        private readonly DbSet<T> _set;

        public BaseRepository(ApplicationContext db)
        {
            _db = db;
            _set = _db.Set<T>();
        }

        public async Task<T> CreateAsync(T entity)
        {
            var newEntity = await _set.AddAsync(entity);
            await _db.SaveChangesAsync();
            return newEntity.Entity;
        }

        public async Task<IEnumerable<T>> CreateRangeAsync(IEnumerable<T> entities)
        {
            _set.AddRange(entities);
            await _db.SaveChangesAsync();
            return entities;
        }

        public IQueryable<T> GetAllQueryable()
        {
            return _set.AsQueryable();
        }

        public async Task<T> GetByAsync(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _set;
            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            return await query.FirstOrDefaultAsync(expression);
        }

        public async Task RemoveAsync(T entity)
        {
            _set.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<int> RemoveRangeAsync(IEnumerable<T> entities)
        {
            _set.RemoveRange(entities);
            return await _db.SaveChangesAsync();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _set.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateRangeAsync(IEnumerable<T> entities)
        {
            _set.UpdateRange(entities);
            await _context.SaveChangesAsync();
        }
    }
}
