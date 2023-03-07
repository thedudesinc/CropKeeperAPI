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

    public Task<bool> Authenticate(LoginInput login)
    {
        return _repository.Authenticate(login);
    }
}
