using Starter.Application.Repositories;
using Starter.Domain.Entities;
using Starter.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starter.Infrastructure.Persistence.Repositories.Implementation
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(DataContext context) : base(context)
        {
        }
    }
}
