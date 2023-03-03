using CropKeeperApi.Domain.Abstractions.Entities;

namespace CropKeeperApi.Domain.Models.Inputs;

public class GardenPlotCropInput : IInput
{
    public string GardenPlotId { get; set; } = string.Empty;

    public string CropId { get; set; } = string.Empty;

    public string FabricId { get; set; } = string.Empty;

    public int Quantity { get; set; }
}
