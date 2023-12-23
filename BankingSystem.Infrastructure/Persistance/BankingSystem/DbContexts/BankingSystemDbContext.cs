using BankingSystem.Core.Entities.Balances;
using BankingSystem.Core.Entities.Bills;
using BankingSystem.Core.Entities.ServiceProviders;
using BankingSystem.Core.Entities.Transactions;
using BankingSystem.Core.Entities.Users;
using BankingSystem.Infrastructure.Persistance.BankingSystem.DbContexts.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Infrastructure.Persistance.BankingSystem.DbContexts
{
    public class BankingSystemDbContext : DbContext
    {
        public BankingSystemDbContext(DbContextOptions<BankingSystemDbContext> options) : base(options) 
        { }

        public virtual DbSet<Balance> Balances { get; set; } = default!;
        public virtual DbSet<Bill> Bills { get; set; } = default!;
        public virtual DbSet<ServiceProvider> ServiceProviders { get; set; } = default!; 
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<User> Users { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new BalanceEntityConfiguration());
            builder.ApplyConfiguration(new BillEntityConfiguration());
            builder.ApplyConfiguration(new ServiceProviderEntityConfiguration());
            builder.ApplyConfiguration(new TransactionEntityConfiguration());
            builder.ApplyConfiguration(new UserEntityConfiguration());
        }
    }
}
