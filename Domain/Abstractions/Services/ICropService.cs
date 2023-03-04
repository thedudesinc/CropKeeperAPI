using System.Linq.Expressions;
using CropKeeperApi.Domain.Models.Inputs;
using CropKeeperApi.Domain.Models.Outputs;

namespace CropKeeperApi.Domain.Abstractions.Services;

public interface ICropService
{
    Task<IEnumerable<CropOutput>> Get(CancellationToken ct);

    Task<CropOutput> Get(Guid id, CancellationToken ct);

    Task<CropOutput> Create(CropInput input, CancellationToken ct);

    Task<CropOutput> Update(Guid id, CropInput input, CancellationToken ct);

    Task Delete(Guid id, CancellationToken ct);
}
