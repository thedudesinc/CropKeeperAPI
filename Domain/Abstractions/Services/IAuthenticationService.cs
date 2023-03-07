using CropKeeperApi.Domain.Models.Inputs;

namespace CropKeeperApi.Domain.Abstractions.Services;

public interface IAuthenticationService
{
    Task<bool> Authenticate(LoginInput login);
}
