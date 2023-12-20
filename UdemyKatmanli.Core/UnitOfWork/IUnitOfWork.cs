using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyKatmanli.Core.UnitOfWork;

public interface IUnitOfWork<T> where T : class
{
    Task CommitAsync();
    void Commit();
}
