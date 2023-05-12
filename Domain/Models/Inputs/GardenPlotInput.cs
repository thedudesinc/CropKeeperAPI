using CropKeeperApi.Domain.Abstractions.Entities;

namespace CropKeeperApi.Domain.Models.Inputs;

public class GardenPlotInput : IInput
{
    public string UserId { get; set; } = string.Empty;

    public string FabricJson { get; set; } = string.Empty;

    public string PlotName { get; set; } = string.Empty;

    public int HardinessZone { get; set; }

    public DateTime LastFrostDate { get; set; }

    public string ZipCode { get; set; } = string.Empty;

    public string? Notes { get; set; }
}
