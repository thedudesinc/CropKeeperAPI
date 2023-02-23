using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using CropKeeperApi.Domain.Abstractions.Repositories;
using CropKeeperApi.Domain.Abstractions.Entities;
using CropKeeperApi.Persistance;

namespace CropKeeperApi.Persistence.Repositories;

public class GenericRepository<TEntity> : IGenericRepository<TEntity>
    where TEntity : class, IEntity
{
    private readonly CropKeeperContext _context;

    public GenericRepository(CropKeeperContext context) => _context = context;

    public IQueryable<TEntity> Get()
    {
        return _context.Set<TEntity>().AsNoTracking();
    }

    public async Task<TEntity> Get(Guid id)
    {
        return await _context.Set<TEntity>()
                    .AsNoTracking()
                    .SingleAsync(e => e.Id == id);
    }

    public async Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate)
    {
        return await _context.Set<TEntity>().Where(predicate).ToListAsync();
    }

    public async Task Create(TEntity entity)
    {
        entity.DateCreated = DateTime.Now;
        entity.DateModified = DateTime.Now;

        await _context.Set<TEntity>().AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Update(Guid id, TEntity entity)
    {
        entity.DateModified = DateTime.Now;

        _context.Set<TEntity>().Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
        var entity = await Get(id);
        entity.DateDeleted = DateTime.Now;

        _context.Set<TEntity>().Update(entity);
        await _context.SaveChangesAsync();
    }
}
