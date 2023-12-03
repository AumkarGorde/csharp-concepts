using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starter.Application.Repositories.UnitOfWork
{
    public interface IUnitOfWork
    {
        IPersonRepository Persons { get; }
        // Other repositories...
        Task<int> SaveChangesAsync();
    }
}
