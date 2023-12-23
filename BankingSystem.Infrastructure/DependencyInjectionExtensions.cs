using BankingSystem.Core.Persistance.BankingSystem;
using BankingSystem.Core.Persistance.BankingSystem.Repositories;
using BankingSystem.Infrastructure.Persistance.BankingSystem.DbContexts;
using BankingSystem.Infrastructure.Persistance.BankingSystem.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Infrastructure
{
    public static class DependencyInjectionExtensions
    {
        public static void AddInfrastucture(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BankingSystemDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("BankingSystem"));
            });

            services.AddScoped<IBankingSystemUnitOfWork, BankingSystemUnitOfWork>();

            services.AddScoped<IBalanceRepository, BalanceRepository>();
            services.AddScoped<IBillRepository, BillRepository>();
            services.AddScoped<IServiceProviderRepository, ServiceProviderRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
