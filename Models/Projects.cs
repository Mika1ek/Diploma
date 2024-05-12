using System.Text.Json.Serialization;
using Diploma.Models;

namespace Diploma.Models;

public record Projects
{
    [JsonPropertyName("page")] public int Page { get; set; }
    [JsonPropertyName("prev_page")] public int? Prev_page { get; set; }
    [JsonPropertyName("next_page")] public int? Next_page { get; set; }
    [JsonPropertyName("last_page")] public int Last_page { get; set; }
    [JsonPropertyName("per_page")] public int Per_page { get; set; }
    [JsonPropertyName("total")] public int Total { get; set; }
    [JsonPropertyName("result")] public Project[] Result { get; set; }
}