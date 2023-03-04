using System.Linq.Expressions;
using CropKeeperApi.Domain.Abstractions.Repositories;
using CropKeeperApi.Domain.Abstractions.Services;
using CropKeeperApi.Domain.Models.Inputs;
using CropKeeperApi.Domain.Models.Outputs;

namespace CropKeeperApi.Domain.Services;

public class GardenPlotCropService : IGardenPlotCropService
{
    private readonly IGardenPlotCropRepository _repository;

    public GardenPlotCropService(IGardenPlotCropRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<GardenPlotCropOutput>> Get(CancellationToken ct)
    {
        return await _repository.Get(ct);
    }

    public async Task<GardenPlotCropOutput> Get(Guid id, CancellationToken ct)
    {
        return await _repository.Get(id, ct);
    }

    public async Task<GardenPlotCropOutput> Create(GardenPlotCropInput input, CancellationToken ct)
    {
        return await _repository.Create(input, ct);
    }

    public async Task<GardenPlotCropOutput> Update(Guid id, GardenPlotCropInput input, CancellationToken ct)
    {
        return await _repository.Update(id, input, ct);
    }

    public async Task Delete(Guid id, CancellationToken ct)
    {
        await _repository.Delete(id, ct);
    }
}
