using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace UdemyKatmanli.Core.Entities;

public class Category:BaseEntity
{
    public String Name { get; set; }
    public ICollection<Product> Products { get; set; }
}
