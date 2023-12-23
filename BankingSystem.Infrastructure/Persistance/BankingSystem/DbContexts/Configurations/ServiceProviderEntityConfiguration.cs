using BankingSystem.Core.Entities.ServiceProviders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Infrastructure.Persistance.BankingSystem.DbContexts.Configurations
{
    public class ServiceProviderEntityConfiguration : IEntityTypeConfiguration<ServiceProvider>
    {
        public void Configure(EntityTypeBuilder<ServiceProvider> builder)
        {
            builder.Property(x => x.Id).HasColumnType("varchar(36)");

        }
    }
}
