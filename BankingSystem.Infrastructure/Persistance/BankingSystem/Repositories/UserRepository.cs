using BankingSystem.Core.Entities.Users;
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
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        private readonly BankingSystemDbContext context;

        public UserRepository(BankingSystemDbContext context)
            : base(context)
        {
            this.context = context;
        }
    }
}
