using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyKatmanli.Core.Entities;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreateData { get; set; }
    public DateTime UpdateDate { get; set; }
}
