using Microsoft.EntityFrameworkCore;
using Starter.Application.Repositories;
using Starter.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starter.Infrastructure.Persistence.Repositories.Implementation
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DataContext _context;
        public readonly DbSet<T> _entities;
        public Repository(DataContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }
        public async Task AddAsync(T entity)
        {
            await _entities.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _entities.Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _entities.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _entities.FindAsync(id);
        }

        public void Update(T entity)
        {
            _entities.Update(entity);
        }
    }
}
