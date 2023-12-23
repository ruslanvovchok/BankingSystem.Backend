using BankingSystem.Core.Persistance.BankingSystem.Repositories;
using BankingSystem.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Core.Persistance.BankingSystem
{
    public interface IBankingSystemUnitOfWork : IUnitOfWork
    {
        IBalanceRepository BalanceRepository { get; }
        IBillRepository BillRepository { get; }
        IServiceProviderRepository ServiceProviderRepository { get; }
        ITransactionRepository TransactionRepository { get; }
        IUserRepository UserRepository { get; }
    }
}
