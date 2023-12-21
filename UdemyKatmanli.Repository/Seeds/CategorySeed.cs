using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UdemyKatmanli.Core.Entities;

namespace UdemyKatmanli.Repository.Seeds;

public class CategorySeed : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasData(
              new Category { Id = 1, Name = "Kalemler" },
              new Category { Id = 2, Name = "Kitaplar" },
              new Category { Id = 3, Name = "Defterler" });
    }
}
