using CropKeeperApi.Domain.Abstractions.Entities;

namespace CropKeeperApi.Domain.Models.Inputs;

public class CropInput : IInput
{
    public string Name { get; set; } = String.Empty;

    public int MaxHardiness { get; set; }

    public int MinHardiness { get; set; }

    public string SunExposure { get; set; } = String.Empty;

    public string WaterRequirements { get; set; } = String.Empty;

    public string PlantHabit { get; set; } = String.Empty;

    public bool IsPerennial { get; set; }
}
