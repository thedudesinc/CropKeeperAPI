using System.Linq.Expressions;
using CropKeeperApi.Domain.Abstractions.Entities;

namespace CropKeeperApi.Domain.Abstractions.Repositories;

public interface IGenericRepository<TEntity> where TEntity : class, IEntity
{
    IQueryable<TEntity> Get();

    Task<TEntity> Get(Guid id);

    Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);

    Task Create(TEntity entity);

    Task Update(Guid id, TEntity entity);

    Task Delete(Guid id);
}
