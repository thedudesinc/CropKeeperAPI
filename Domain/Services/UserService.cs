using System.Linq.Expressions;
using CropKeeperApi.Domain.Abstractions.Repositories;
using CropKeeperApi.Domain.Abstractions.Services;
using CropKeeperApi.Domain.Models.Inputs;
using CropKeeperApi.Domain.Models.Outputs;

namespace CropKeeperApi.Domain.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _repository;

    public UserService(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<UserOutput>> Get(CancellationToken ct)
    {
        return await _repository.Get(ct);
    }

    public async Task<UserOutput> Get(Guid id, CancellationToken ct)
    {
        return await _repository.Get(id, ct);
    }

    public async Task<UserOutput> Create(UserInput input, CancellationToken ct)
    {
        input.Password = BCrypt.Net.BCrypt.HashPassword(input.Password);

        return await _repository.Create(input, ct);
    }

    public async Task<UserOutput> Update(Guid id, UserInput input, CancellationToken ct)
    {
        return await _repository.Update(id, input, ct);
    }

    public async Task Delete(Guid id, CancellationToken ct)
    {
        await _repository.Delete(id, ct);
    }
}
