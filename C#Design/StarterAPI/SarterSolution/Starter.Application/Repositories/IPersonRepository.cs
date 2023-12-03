using Starter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starter.Application.Repositories
{
    /* If you want to retrive some kind of custom data from a specific repository use this
     * eg: Retive a person of age 26
     */
    public interface IPersonRepository : IRepository<Person>
    {
    }
}
