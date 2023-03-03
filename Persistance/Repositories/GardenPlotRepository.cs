using AutoMapper;
using CropKeeperApi.Domain.Abstractions.Repositories;
using CropKeeperApi.Domain.Models.Inputs;
using CropKeeperApi.Domain.Models.Outputs;
using CropKeeperApi.Persistance.Entities;
using CropKeeperApi.Persistence.Repositories;

namespace CropKeeperApi.Persistance.Repositories;

public class GardenPlotRepository : GenericRepository<GardenPlot, GardenPlotInput, GardenPlotOutput>, IGardenPlotRepository
{
    public GardenPlotRepository(CropKeeperContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
