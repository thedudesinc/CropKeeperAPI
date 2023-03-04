using System.Linq.Expressions;
using CropKeeperApi.Domain.Abstractions.Repositories;
using CropKeeperApi.Domain.Abstractions.Services;
using CropKeeperApi.Domain.Models.Inputs;
using CropKeeperApi.Domain.Models.Outputs;

namespace CropKeeperApi.Domain.Services;

public class CropService : ICropService
{
    private readonly ICropRepository _repository;

    public CropService(ICropRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<CropOutput>> Get(CancellationToken ct)
    {
        return await _repository.Get(ct);
    }

    public async Task<CropOutput> Get(Guid id, CancellationToken ct)
    {
        return await _repository.Get(id, ct);
    }

    public async Task<CropOutput> Create(CropInput input, CancellationToken ct)
    {
        return await _repository.Create(input, ct);
    }

    public async Task<CropOutput> Update(Guid id, CropInput input, CancellationToken ct)
    {
        return await _repository.Update(id, input, ct);
    }

    public async Task Delete(Guid id, CancellationToken ct)
    {
        await _repository.Delete(id, ct);
    }
}
