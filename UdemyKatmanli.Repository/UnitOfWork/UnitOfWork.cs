using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyKatmanli.Core.UnitOfWork;
using UdemyKatmanli.Repository.ConDbContext;


namespace UdemyKatmanli.Repository.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public void Commit()
    {
        _context.SaveChanges();
    }

    public async Task CommitAsync()
    {
        await _context.SaveChangesAsync();
    }
}
