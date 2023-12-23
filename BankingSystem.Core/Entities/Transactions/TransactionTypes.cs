using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Core.Entities.Transactions
{
    public enum TransactionTypes
    {
        Transfer = 1,
        UtilityBill = 2,
        BalanceReplenishment = 3
    }
}
