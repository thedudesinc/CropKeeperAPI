using AutoMapper;
using CropKeeperApi.Domain.Abstractions.Repositories;
using CropKeeperApi.Domain.Models.Inputs;
using CropKeeperApi.Domain.Models.Outputs;
using CropKeeperApi.Persistance.Entities;
using CropKeeperApi.Persistence.Repositories;

namespace CropKeeperApi.Persistance.Repositories;

public class NotificationRepository : GenericRepository<Notification, NotificationInput, NotificationOutput>, INotificationRepository
{
    public NotificationRepository(CropKeeperContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
