using BankingSystem.Core.Entities.Bills;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Infrastructure.Persistance.BankingSystem.DbContexts.Configurations
{
    public class BillEntityConfiguration : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.Property(x => x.Id).HasColumnType("varchar(36)");
            builder.Property(x => x.UserId).HasColumnType("varchar(36)");
            builder.Property(x => x.ServiceProviderId).HasColumnType("varchar(36)");
            builder.Property(x => x.RecipientId).HasColumnType("varchar(36)");

            builder.HasOne(x => x.User)
                   .WithMany(x => x.Bills)
                   .HasForeignKey(x => x.UserId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.ServiceProvider)
                   .WithMany(x => x.Bills)
                   .HasForeignKey(x => x.ServiceProviderId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Recipient)
                   .WithMany(x => x.RecipientBills)
                   .HasForeignKey(x => x.RecipientId)
                   .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
