using CropKeeperApi.Domain.Abstractions.Repositories;
using CropKeeperApi.Persistance.Entities;
using CropKeeperApi.Persistence.Repositories;

namespace CropKeeperApi.Persistance.Repositories;

public class GardenPlotRepository : GenericRepository<GardenPlot>, IGardenPlotRepository
{
    public GardenPlotRepository(CropKeeperContext context) : base(context)
    {
    }
}
