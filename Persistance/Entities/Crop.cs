namespace CropKeeperApi.Persistance.Entities;

public class Crop
{
    public Guid Id { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }

    public DateTime DateDeleted { get; set; }
}
