using CropKeeperApi.Domain.Abstractions.Entities;

namespace CropKeeperApi.Domain.Models.Inputs;

public class GardenPlotPartialInput : IInput
{
    public string FabricJson { get; set; } = string.Empty;

    public string PlotName { get; set; } = string.Empty;

    public int ZipCode { get; set; }

    public string? Notes { get; set; }
}
