using CropKeeperApi.Domain.Abstractions.Entities;

namespace CropKeeperApi.Domain.Models.Outputs;

public class CropOutput : IOutput
{
    public Guid Id { get; set; }

    public string Name { get; set; } = String.Empty;

    public int MaxHardiness { get; set; }

    public int MinHardiness { get; set; }

    public string SunExposure { get; set; } = String.Empty;

    public string WaterRequirements { get; set; } = String.Empty;

    public string PlantHabit { get; set; } = String.Empty;

    public bool IsPerennial { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }

    public DateTime? DateDeleted { get; set; }
}
