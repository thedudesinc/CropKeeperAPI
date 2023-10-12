namespace CropKeeperApi.App.Requests;

public class VerifyEmailRequest
{
    public string OmittedEmail { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

}
