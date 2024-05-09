using Diploma.Models.Enums;


namespace Diploma.Models;
public record User
{
    public UserType UserType { get; set; }
    public string Username { get; init; } = string.Empty;
    public string Password { get; init; } = string.Empty;
}
