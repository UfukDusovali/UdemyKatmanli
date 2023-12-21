using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UdemyKatmanli.Core.Repositories;
using UdemyKatmanli.Repository.DbContexts;

namespace UdemyKatmanli.Repository.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{

    protected readonly AppDbContext _context;
    private readonly DbSet<T> _dbSet;
    public GenericRepository(AppDbContext context, DbSet<T> dbSet)
    {
        _context = context;
        _dbSet = dbSet;
    }



    public Task AddAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public void AddRangeAsync(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }

    public Task<bool> AnyAsync(Expression<Func<T>> expression)
    {
        throw new NotImplementedException();
    }

    public IQueryable<T> GetAll(Expression<Func<T, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetByIdAsync(int Id)
    {
        throw new NotImplementedException();
    }

    public void Remove(T enetity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }

    public void UpdateDate(T entity)
    {
        throw new NotImplementedException();
    }

    public IQueryable<T> Where(Expression<Func<T, bool>> expression)
    {
        throw new NotImplementedException();
    }
}
