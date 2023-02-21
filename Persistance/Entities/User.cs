namespace CropKeeperApi.Persistance.Entities;

public class User
{
    public Guid Id { get; set; }

    public string DisplayName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Passowrd { get; set; } = string.Empty;

    public bool AllowEmailNotifications { get; set; } = true;

    public bool AllowSiteNotifications { get; set; } = true;

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }

    public DateTime DateDeleted { get; set; }
}
