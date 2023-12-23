using BankingSystem.Core.Entities.Users;
using BankingSystem.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Core.Entities.Balances
{
    public class Balance : Entity
    {
        public Guid UserId { get; set; } = default!;
        public User User { get; set; } = default!;
        public decimal CurrentBalance { get; set; }
    }
}
