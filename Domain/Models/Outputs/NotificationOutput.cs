using CropKeeperApi.Domain.Abstractions.Entities;

namespace CropKeeperApi.Domain.Models.Outputs;

public class NotificationOutput : IOutput
{
    public Guid Id { get; set; }

    public string UserId { get; set; } = string.Empty;

    public string Content { get; set; } = string.Empty;

    public bool IsRead { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }

    public DateTime? DateDeleted { get; set; }
}
