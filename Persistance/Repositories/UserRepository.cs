using AutoMapper;
using Microsoft.EntityFrameworkCore;
using CropKeeperApi.Domain.Abstractions.Repositories;
using CropKeeperApi.Domain.Models.Inputs;
using CropKeeperApi.Domain.Models.Outputs;
using CropKeeperApi.Persistance.Entities;
using CropKeeperApi.Persistence.Repositories;

namespace CropKeeperApi.Persistance.Repositories;

public class UserRepository : GenericRepository<User, UserInput, UserOutput>, IUserRepository
{
    public UserRepository(CropKeeperContext context, IMapper mapper) : base(context, mapper)
    {

    }

    public async Task<bool> Authenticate(LoginInput login)
    {
        var user = await _context.Users.Where(user => user.Email == login.Email && user.Password == login.Password).SingleOrDefaultAsync();

        return user != null;
    }
}
