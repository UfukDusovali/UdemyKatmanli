using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


        modelBuilder.Entity<ProductFeature>().HasData(new ProductFeature()
        {
            Id = 1,
            Color = "Kırmızı",
            Height = 100,
            Width = 200,
            ProductId = 1


        },
         new ProductFeature()
         {
             Id = 2,
             Color = "Mavi",
             Height = 300,
             Width = 500,
             ProductId = 2


         }


         );

    }
}

