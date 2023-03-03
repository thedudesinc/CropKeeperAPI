using CropKeeperApi.Domain.Models.Inputs;
using CropKeeperApi.Domain.Models.Outputs;
using CropKeeperApi.Persistance.Entities;

namespace CropKeeperApi.Domain.Abstractions.Repositories;

public interface IUserRepository : IGenericRepository<User, UserInput, UserOutput>
{

}
