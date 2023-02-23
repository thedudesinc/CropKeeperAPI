using CropKeeperApi.Domain.Abstractions.Entities;

namespace CropKeeperApi.Persistance.Entities;

public class GardenPlotCrop : IEntity
{
    public Guid Id { get; set; }

    public string GardenPlotId { get; set; } = string.Empty;

    public string CropId { get; set; } = string.Empty;

    public string FabricId { get; set; } = string.Empty;

    public int Quantity { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }

    public DateTime? DateDeleted { get; set; }
}
