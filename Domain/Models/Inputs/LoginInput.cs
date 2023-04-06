using System.ComponentModel.DataAnnotations;

namespace CropKeeperApi.Domain.Models.Inputs;

public class LoginInput
{
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    public string Password { get; set; } = string.Empty;
}
