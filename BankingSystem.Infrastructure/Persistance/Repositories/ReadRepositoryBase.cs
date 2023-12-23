using BankingSystem.Shared.Entities;
using BankingSystem.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Infrastructure.Persistance.Repositories
{
    public abstract class ReadRepositoryBase<T> : IReadRepositoryBase<T> where T : Entity
    {
        private readonly DbContext context;

        public ReadRepositoryBase(DbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<T>> ListAsync(CancellationToken cancellationToken = default)
        {
            return await context.Set<T>().ToListAsync(cancellationToken);
        }

        public async Task<T?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await context.Set<T>().FindAsync(id, cancellationToken);
        }
    }
}
