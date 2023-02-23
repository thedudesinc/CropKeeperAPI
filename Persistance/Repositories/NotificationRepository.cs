using CropKeeperApi.Domain.Abstractions.Repositories;
using CropKeeperApi.Persistance.Entities;
using CropKeeperApi.Persistence.Repositories;

namespace CropKeeperApi.Persistance.Repositories;

public class NotificationRepository : GenericRepository<Notification>, INotificationRepository
{
    public NotificationRepository(CropKeeperContext context) : base(context)
    {
    }
}
