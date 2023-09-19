using CropKeeperApi.Domain.Models.Inputs;
using CropKeeperApi.Domain.Models.Outputs;

namespace CropKeeperApi.Domain.Abstractions.Services;

public interface IAuthenticationService
{
    Task<UserOutput?> Authenticate(LoginInput login, CancellationToken ct);
}
