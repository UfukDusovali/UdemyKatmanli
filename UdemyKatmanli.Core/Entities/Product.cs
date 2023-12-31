using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyKatmanli.Core.Entities;

public class Product:BaseEntity
{
    public String Name { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public ProductFeature ProductFeature { get; set; }
}
