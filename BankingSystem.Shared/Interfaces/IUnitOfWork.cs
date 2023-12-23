using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Shared.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> SaveAsync(CancellationToken cancellationToken = default);
    }
}
