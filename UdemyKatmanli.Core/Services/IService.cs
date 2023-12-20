using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace UdemyKatmanli.Core.Services;

public interface IService<T> where T : class
{
    Task<T> GetByIdAsync(int Id);
    Task<IEnumerable<T>> GetAllAsync();
    IQueryable<T> Where(Expression<Func<T, bool>> expression);
    Task<bool> AnyAsync(Expression<Func<T>> expression);
    Task AddAsync(T entity);
    Task AddRange(IEnumerable<T> entities);
    Task UpdateDateAsync(T entity);
    Task RemoveAsync(T entity);
    Task RemoveAsync(IEnumerable<T> entities);
}
