using System.Linq.Expressions;
using CropKeeperApi.Domain.Models.Inputs;
using CropKeeperApi.Domain.Models.Outputs;

namespace CropKeeperApi.Domain.Abstractions.Services;

public interface INotificationService
{
    Task<IEnumerable<NotificationOutput>> Get(CancellationToken ct);

    Task<NotificationOutput> Get(Guid id, CancellationToken ct);

    Task<NotificationOutput> Create(NotificationInput input, CancellationToken ct);

    Task<NotificationOutput> Update(Guid id, NotificationInput input, CancellationToken ct);

    Task Delete(Guid id, CancellationToken ct);
}
