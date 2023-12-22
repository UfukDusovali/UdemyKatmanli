using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace UdemyKatmanli.Core.Repositories;

public interface IGenericRepository<T> where T : class
{
    Task<T> GetByIdAsync(int Id);
    IQueryable<T> GetAll();
    IQueryable<T> Where(Expression<Func<T, bool>> expression);
    Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
    Task AddAsync(T entity);
    Task AddRangeAsync(IEnumerable<T> entities);
    void UpdateDate(T entity);
    void Remove(T entity);
    void RemoveRange(IEnumerable<T> entities);
}
