using System.Linq.Expressions;
using CropKeeperApi.Domain.Abstractions.Repositories;
using CropKeeperApi.Domain.Abstractions.Services;
using CropKeeperApi.Domain.Models.Inputs;
using CropKeeperApi.Domain.Models.Outputs;

namespace CropKeeperApi.Domain.Services;

public class NotificationService : INotificationService
{
    private readonly INotificationRepository _repository;

    public NotificationService(INotificationRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<NotificationOutput>> Get(CancellationToken ct)
    {
        return await _repository.Get(ct);
    }

    public async Task<NotificationOutput> Get(Guid id, CancellationToken ct)
    {
        return await _repository.Get(id, ct);
    }

    public async Task<NotificationOutput> Create(NotificationInput input, CancellationToken ct)
    {
        return await _repository.Create(input, ct);
    }

    public async Task<NotificationOutput> Update(Guid id, NotificationInput input, CancellationToken ct)
    {
        return await _repository.Update(id, input, ct);
    }

    public async Task Delete(Guid id, CancellationToken ct)
    {
        await _repository.Delete(id, ct);
    }
}
