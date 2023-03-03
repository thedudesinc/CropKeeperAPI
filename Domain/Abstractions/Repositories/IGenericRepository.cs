using System.Linq.Expressions;
using CropKeeperApi.Domain.Abstractions.Entities;

namespace CropKeeperApi.Domain.Abstractions.Repositories;

public interface IGenericRepository<TEntity, TInput, TOutput>
    where TEntity : class, IEntity
    where TInput : class, IInput
    where TOutput : class, IOutput
{
    Task<IEnumerable<TOutput>> Get(CancellationToken ct);

    Task<TOutput> Get(Guid id, CancellationToken ct);

    // Task<IEnumerable<TOutput>> Find(Expression<Func<TInput, bool>> predicate);

    Task<TOutput> Create(TInput input, CancellationToken ct);

    Task<TOutput> Update(Guid id, TInput input, CancellationToken ct);

    Task Delete(Guid id, CancellationToken ct);
}
