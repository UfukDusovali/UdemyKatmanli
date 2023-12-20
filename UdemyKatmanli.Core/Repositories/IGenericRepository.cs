using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace UdemyKatmanli.Core.Repositories;

public interface IGenericRepository<T> where T : class
{
    Task<T> GetByIdAsync(int Id);
    IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
    IQueryable<T> Where(Expression<Func<T, bool>> expression);
    Task<bool> AnyAsync(Expression<Func<T>> expression);
    Task AddAsync(T entity);
    void AddRangeAsync(IEnumerable<T> entities);
    void UpdateDate(T entity);
    void Remove(T enetity);
    void RemoveRange(IEnumerable<T> entities);
}
