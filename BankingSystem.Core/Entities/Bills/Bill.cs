using BankingSystem.Core.Entities.ServiceProviders;
using BankingSystem.Core.Entities.Users;
using BankingSystem.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Core.Entities.Bills
{
    public class Bill : Entity
    {
        public Guid UserId { get; set; } = default!;
        public User User { get; set; } = default!;
        public string BillName { get; set; } = default!;
        public Guid? ServiceProviderId { get; set; }
        public ServiceProvider? ServiceProvider { get; set; }
        public Guid? RecipientId { get; set; }
        public User? Recipient { get; set; }
        public decimal? BillAmount { get; set; }
    }
}
