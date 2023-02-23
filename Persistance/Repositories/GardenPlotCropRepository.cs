using CropKeeperApi.Domain.Abstractions.Repositories;
using CropKeeperApi.Persistance.Entities;
using CropKeeperApi.Persistence.Repositories;

namespace CropKeeperApi.Persistance.Repositories;

public class GardenPlotCropRepository : GenericRepository<GardenPlotCrop>, IGardenPlotCropRepository
{
    public GardenPlotCropRepository(CropKeeperContext context) : base(context)
    {
    }
}
