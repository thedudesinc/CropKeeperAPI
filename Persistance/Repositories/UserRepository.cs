using AutoMapper;
using Microsoft.EntityFrameworkCore;
using CropKeeperApi.Domain.Abstractions.Repositories;
using CropKeeperApi.Domain.Models.Inputs;
using CropKeeperApi.Domain.Models.Outputs;
using CropKeeperApi.Persistance.Entities;
using CropKeeperApi.Persistence.Repositories;

namespace CropKeeperApi.Persistance.Repositories;

public class UserRepository : GenericRepository<User, UserInput, UserOutput>, IUserRepository
{
    public UserRepository(CropKeeperContext context, IMapper mapper) : base(context, mapper)
    {

    }

    public new async Task<UserOutput> Update(Guid id, UserInput input, CancellationToken ct)
    {
        var existing = await _context.Set<User>()
                    .SingleAsync(e => e.Id == id, ct);

        var entity = _mapper.Map(input, existing);

        entity.DateModified = DateTime.Now;

        _context.Set<User>().Update(entity);

        if (string.IsNullOrEmpty(input.Password))
        {
            _context.Entry(entity).Property(entity => entity.Password).IsModified = false;
        }

        await _context.SaveChangesAsync(ct);

        return (UserOutput)_mapper.Map(entity, entity.GetType(), typeof(UserOutput));
    }
}
