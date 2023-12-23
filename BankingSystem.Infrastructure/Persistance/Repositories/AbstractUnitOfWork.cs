using BankingSystem.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Infrastructure.Persistance.Repositories
{
    public class AbstractUnitOfWork : IUnitOfWork
    {
        private readonly DbContext context;

        public AbstractUnitOfWork(DbContext context)
        {
            this.context = context;
        }

        public async Task<int> SaveAsync(CancellationToken cancellationToken = default)
        {
            return await context.SaveChangesAsync(cancellationToken);
        }
    }
}
