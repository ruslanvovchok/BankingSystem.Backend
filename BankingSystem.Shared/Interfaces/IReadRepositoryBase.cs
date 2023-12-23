using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Shared.Interfaces
{
    public interface IReadRepositoryBase<T> where T : class
    {
        Task<T?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        //Task<T?> GetFirstAsync(Specification<T> specification, CancellationToken cancellationToken = default);
        Task<IEnumerable<T>> ListAsync(CancellationToken cancellationToken = default);
        //Task<IEnumerable<TResult>> ListAsync<TResult>(IMapper mapper, CancellationToken cancellationToken = default);
        //Task<IEnumerable<T>> ListAsync(Specification<T> specification, CancellationToken cancellationToken = default);
        //Task<IEnumerable<TResult>> ListAsync<TResult>(Specification<T> specification, IMapper mapper, CancellationToken cancellationToken = default);
        //Task<int> CountAsync(CancellationToken cancellationToken = default);
        //Task<int> CountAsync(Specification<T> specification, CancellationToken cancellationToken = default);
        //Task<TResult?> GetFirstAsync<TResult>(Specification<T> specification, IMapper mapper, CancellationToken cancellationToken = default);
        //Task<IEnumerable<TResult>> ListAsync<TResult>(Specification<T> specification, int? skip, int? take, IMapper mapper, CancellationToken cancellationToken = default);
        //Task<IEnumerable<T>> ListAsync(Specification<T> specification, int? skip, int? take, CancellationToken cancellationToken = default);
        //Task<TResult?> GetByIdAsync<TResult>(int id, IMapper mapper, CancellationToken cancellationToken = default);
    }
}
