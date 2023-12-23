using BankingSystem.Core.Entities.Transactions;
using BankingSystem.Core.Persistance.BankingSystem.Repositories;
using BankingSystem.Infrastructure.Persistance.BankingSystem.DbContexts;
using BankingSystem.Infrastructure.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Infrastructure.Persistance.BankingSystem.Repositories
{
    public class TransactionRepository : RepositoryBase<Transaction>, ITransactionRepository
    {
        private readonly BankingSystemDbContext context;

        public TransactionRepository(BankingSystemDbContext context)
            : base(context)
        {
            this.context = context;
        }
    }
}
