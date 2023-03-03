using AutoMapper;
using CropKeeperApi.Domain.Abstractions.Repositories;
using CropKeeperApi.Domain.Models.Inputs;
using CropKeeperApi.Domain.Models.Outputs;
using CropKeeperApi.Persistance.Entities;
using CropKeeperApi.Persistence.Repositories;

namespace CropKeeperApi.Persistance.Repositories;

public class GardenPlotCropRepository : GenericRepository<GardenPlotCrop, GardenPlotCropInput, GardenPlotCropOutput>, IGardenPlotCropRepository
{
    public GardenPlotCropRepository(CropKeeperContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
