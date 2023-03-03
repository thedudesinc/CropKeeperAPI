using CropKeeperApi.Domain.Abstractions.Entities;

namespace CropKeeperApi.Domain.Models.Outputs;

public class GardenPlotCropOutput : IOutput
{
    public Guid Id { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }

    public DateTime? DateDeleted { get; set; }
}
