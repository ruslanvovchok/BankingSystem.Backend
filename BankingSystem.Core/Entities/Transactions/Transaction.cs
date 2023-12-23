using BankingSystem.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Core.Entities.Transactions
{
    public class Transaction : Entity
    {
        public TransactionTypes TransactionType { get; set; }
        public DateTime TransactionDate { get; set; } = default!;
        public string Recipient { get; set; } = default!;
        public decimal TransactionAmount { get; set; }
    }
}
