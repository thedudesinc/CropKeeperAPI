using BCrypt.Net;
using CropKeeperApi.Domain.Abstractions.Repositories;
using CropKeeperApi.Domain.Abstractions.Services;
using CropKeeperApi.Domain.Models.Inputs;

namespace CropKeeperApi.Domain.Services;

public class AuthenticationService : IAuthenticationService
{
    private readonly IUserRepository _repository;

    public AuthenticationService(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task<bool> Authenticate(LoginInput login)
    {
        var user = await _repository.Find(user => user.Email == login.Email);

        var singleUser = user.SingleOrDefault();

        if (singleUser == null) return false;

        return BCrypt.Net.BCrypt.Verify(login.Password, singleUser.Password, false, HashType.SHA384);
    }
}
