using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UdemyKatmanli.Core.Entities;

namespace UdemyKatmanli.Repository.DbContexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {


    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductFeature> ProductFeatures { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

    }
}

