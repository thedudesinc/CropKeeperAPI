using BCrypt.Net;
using CropKeeperApi.Domain.Abstractions.Repositories;
using CropKeeperApi.Domain.Abstractions.Services;
using CropKeeperApi.Domain.Models.Inputs;
using CropKeeperApi.Domain.Models.Outputs;

namespace CropKeeperApi.Domain.Services;

public class AuthenticationService : IAuthenticationService
{
    private readonly IUserRepository _repository;

    public AuthenticationService(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task<UserOutput?> Authenticate(LoginInput login, CancellationToken ct)
    {
        var user = (await _repository.Find(user => user.Email == login.Email, ct)).SingleOrDefault();

        if (user == null) return null;

        var matchingPassword = BCrypt.Net.BCrypt.Verify(login.Password, user.Password, false, HashType.SHA384);

        return !!matchingPassword ? user : null;
    }
}
