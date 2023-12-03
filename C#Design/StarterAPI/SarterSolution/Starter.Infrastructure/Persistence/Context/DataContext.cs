using Microsoft.EntityFrameworkCore;
using Starter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starter.Infrastructure.Persistence.Context
{
    public class DataContext: DbContext
    {
        public DbSet<Person> ?Person { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
    }
}
