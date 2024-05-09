using System.Text.Json.Serialization;

namespace Diploma.Models;

public record AutomationRun
{
    [JsonPropertyName("name")] public string? Name { get; set; }
    [JsonPropertyName("source")] public string? Source { get; set; }
}