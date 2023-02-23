using CropKeeperApi.Domain.Abstractions.Entities;

namespace CropKeeperApi.Persistance.Entities;

public class Notification : IEntity
{
    public Guid Id { get; set; }

    public string UserId { get; set; } = string.Empty;

    public string Content { get; set; } = string.Empty;

    public bool IsRead { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }

    public DateTime? DateDeleted { get; set; }
}
