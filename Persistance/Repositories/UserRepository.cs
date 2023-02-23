using CropKeeperApi.Domain.Abstractions.Repositories;
using CropKeeperApi.Persistance.Entities;
using CropKeeperApi.Persistence.Repositories;

namespace CropKeeperApi.Persistance.Repositories;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    public UserRepository(CropKeeperContext context) : base(context)
    {
    }
}
