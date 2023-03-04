using System.Linq.Expressions;
using CropKeeperApi.Domain.Models.Inputs;
using CropKeeperApi.Domain.Models.Outputs;

namespace CropKeeperApi.Domain.Abstractions.Services;

public interface IGardenPlotCropService
{
    Task<IEnumerable<GardenPlotCropOutput>> Get(CancellationToken ct);

    Task<GardenPlotCropOutput> Get(Guid id, CancellationToken ct);

    Task<GardenPlotCropOutput> Create(GardenPlotCropInput input, CancellationToken ct);

    Task<GardenPlotCropOutput> Update(Guid id, GardenPlotCropInput input, CancellationToken ct);

    Task Delete(Guid id, CancellationToken ct);
}
