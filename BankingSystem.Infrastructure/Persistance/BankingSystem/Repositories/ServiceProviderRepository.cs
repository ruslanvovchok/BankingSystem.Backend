using BankingSystem.Core.Entities.ServiceProviders;
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
    public class ServiceProviderRepository : RepositoryBase<ServiceProvider>, IServiceProviderRepository
    {
        private readonly BankingSystemDbContext context;

        public ServiceProviderRepository(BankingSystemDbContext context)
            : base(context)
        {
            this.context = context;
        }
    }
}
