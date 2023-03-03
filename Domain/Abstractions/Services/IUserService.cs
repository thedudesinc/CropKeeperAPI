using System.Linq.Expressions;
using CropKeeperApi.Domain.Models.Inputs;
using CropKeeperApi.Domain.Models.Outputs;

namespace CropKeeperApi.Domain.Abstractions.Services;

public interface IUserService
{
    Task<IEnumerable<UserOutput>> Get(CancellationToken ct);

    Task<UserOutput> Get(Guid id, CancellationToken ct);

    Task<IEnumerable<UserOutput>> Find(Expression<Func<UserInput, bool>> predicate);

    Task<UserOutput> Create(UserInput input, CancellationToken ct);

    Task<UserOutput> Update(Guid id, UserInput input, CancellationToken ct);

    Task Delete(Guid id, CancellationToken ct);
}
