using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using UdemyKatmanli.Core.Repositories;
using UdemyKatmanli.Repository.ConDbContext;


namespace UdemyKatmanli.Repository.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{

    protected readonly AppDbContext _context;
    private readonly DbSet<T> _dbSet;
    public GenericRepository(AppDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
    }

    public async Task AddRangeAsync(IEnumerable<T> entities)
    {
        await _dbSet.AddRangeAsync(entities);
    }

    public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
    {
        return await _dbSet.AnyAsync(expression);
    }

    public IQueryable<T> GetAll()
    {
        return _dbSet.AsNoTracking().AsQueryable();
    }

    public async Task<T> GetByIdAsync(int Id)
    {
        return await _dbSet.FindAsync(Id);
    }

    public void Remove(T entity)
    {
        _dbSet.Remove(entity);
    }

    public void RemoveRange(IEnumerable<T> entities)
    {
        _dbSet.RemoveRange(entities);
    }

    public void UpdateDate(T entity)
    {
        _dbSet.Update(entity);
    }

    public IQueryable<T> Where(Expression<Func<T, bool>> expression)
    {
        return _dbSet.Where(expression);
    }
}
