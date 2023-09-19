namespace CropKeeperApi.App.Responses;

public class LoginResponse
{
    public string DisplayName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string StringToken { get; set; } = string.Empty;

    public bool AllowEmailNotifications { get; set; } = true;

    public bool AllowSiteNotifications { get; set; } = true;
}
