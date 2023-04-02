using System.Security.Cryptography;
using System.Text;
using CropKeeperApi.Domain.Abstractions.Entities;

namespace CropKeeperApi.Domain.Models.Inputs;

public class UserInput : IInput
{
    public string DisplayName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public string Zip { get; set; } = string.Empty;

    public bool AllowEmailNotifications { get; set; } = true;

    public bool AllowSiteNotifications { get; set; } = true;
}
