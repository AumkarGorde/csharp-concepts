using Microsoft.EntityFrameworkCore;
using Starter.Application.Repositories;
using Starter.Application.Repositories.UnitOfWork;
using Starter.Infrastructure.Persistence.Context;

namespace Starter.Infrastructure.Persistence.Repositories.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IPersonRepository Persons { get; }
        private readonly DataContext ?_context;
        public UnitOfWork(DataContext context, IPersonRepository personRepository)
        {
            Persons = personRepository;
            _context = context;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
