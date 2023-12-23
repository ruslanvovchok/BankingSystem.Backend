using BankingSystem.Core.Entities.Balances;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Infrastructure.Persistance.BankingSystem.DbContexts.Configurations
{
    public class BalanceEntityConfiguration : IEntityTypeConfiguration<Balance>
    {
        public void Configure(EntityTypeBuilder<Balance> builder)
        {
            builder.Property(x => x.Id).HasColumnType("varchar(36)");
            builder.Property(x => x.UserId).HasColumnType("varchar(36)");

            builder.HasOne(x => x.User)
                   .WithOne(x => x.Balance)
                   .HasForeignKey<Balance>(x => x.UserId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
