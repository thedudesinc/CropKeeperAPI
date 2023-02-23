using CropKeeperApi.Domain.Abstractions.Repositories;
using CropKeeperApi.Persistance.Entities;
using CropKeeperApi.Persistence.Repositories;

namespace CropKeeperApi.Persistance.Repositories;

public class CropRepository : GenericRepository<Crop>, ICropRepository
{
    public CropRepository(CropKeeperContext context) : base(context)
    {
    }
}
