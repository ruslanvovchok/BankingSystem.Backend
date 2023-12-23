using BankingSystem.Core.Entities.Bills;
using BankingSystem.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Core.Entities.ServiceProviders
{
    public class ServiceProvider : Entity
    {
        public string Name { get; set; } = default!;
        public string? Description { get; set; }

        public ICollection<Bill>? Bills { get; set; } = default!;
    }
}
