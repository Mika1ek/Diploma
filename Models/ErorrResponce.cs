using System.Text.Json.Serialization;

namespace Diploma.Models;

public record ErrorResponse
{
    [JsonPropertyName("message")] public string? Message { get; set; }
    [JsonPropertyName("code")] public int Сode { get; set; }
}