using System.Linq.Expressions;
using CropKeeperApi.Domain.Abstractions.Repositories;
using CropKeeperApi.Domain.Abstractions.Services;
using CropKeeperApi.Domain.Models.Inputs;
using CropKeeperApi.Domain.Models.Outputs;

namespace CropKeeperApi.Domain.Services;

public class GardenPlotService : IGardenPlotService
{
    private readonly IGardenPlotRepository _repository;

    public GardenPlotService(IGardenPlotRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<GardenPlotOutput>> Get(CancellationToken ct)
    {
        return await _repository.Get(ct);
    }

    public async Task<GardenPlotOutput> Get(Guid id, CancellationToken ct)
    {
        return await _repository.Get(id, ct);
    }

    public async Task<IEnumerable<GardenPlotOutput>> GetByUserId(Guid id, CancellationToken ct)
    {
        return await _repository.Find((gardenPlot) => gardenPlot.UserId == id, ct);
    }

    public async Task<GardenPlotOutput> Create(GardenPlotInput input, CancellationToken ct)
    {
        return await _repository.Create(input, ct);
    }

    public async Task<GardenPlotOutput> Update(Guid id, GardenPlotInput input, CancellationToken ct)
    {
        return await _repository.Update(id, input, ct);
    }

    public async Task Delete(Guid id, CancellationToken ct)
    {
        await _repository.Delete(id, ct);
    }
}
