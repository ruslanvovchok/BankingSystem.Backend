using BankingSystem.Core.Persistance.BankingSystem;
using BankingSystem.Core.Persistance.BankingSystem.Repositories;
using BankingSystem.Infrastructure.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Infrastructure.Persistance.BankingSystem.DbContexts
{
    public class BankingSystemUnitOfWork : AbstractUnitOfWork, IBankingSystemUnitOfWork
    {
        public BankingSystemUnitOfWork(BankingSystemDbContext context,
                                       IBalanceRepository balanceRepository,
                                       IBillRepository billRepository,
                                       IServiceProviderRepository serviceProviderRepository,
                                       ITransactionRepository transactionRepository,
                                       IUserRepository userRepository)
            : base(context)
        {
            BalanceRepository = balanceRepository;
            BillRepository = billRepository;
            ServiceProviderRepository = serviceProviderRepository;
            TransactionRepository = transactionRepository;
            UserRepository = userRepository;
        }

        public IBalanceRepository BalanceRepository { get; private set; }

        public IBillRepository BillRepository { get; private set; }

        public IServiceProviderRepository ServiceProviderRepository { get; private set; }

        public ITransactionRepository TransactionRepository { get; private set; }

        public IUserRepository UserRepository { get; private set; }
    }
}
