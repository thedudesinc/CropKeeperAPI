using CropKeeperApi.Domain.Models.Inputs;
using CropKeeperApi.Domain.Models.Outputs;

namespace CropKeeperApi.Domain.Abstractions.Services;

public interface IGardenPlotService
{
    Task<IEnumerable<GardenPlotOutput>> Get(CancellationToken ct);

    Task<GardenPlotOutput> Get(Guid id, CancellationToken ct);

    Task<IEnumerable<GardenPlotOutput>> GetByUserId(Guid id, CancellationToken ct);

    Task<GardenPlotOutput> Create(GardenPlotInput input, CancellationToken ct);

    Task<GardenPlotOutput> Update(Guid id, GardenPlotInput input, CancellationToken ct);

    Task Delete(Guid id, CancellationToken ct);
}
