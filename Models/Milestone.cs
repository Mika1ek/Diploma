using System.Text.Json.Serialization;

namespace Diploma.Models;
public record Milestone
{
    [JsonPropertyName("page")] public int Page { get; set; }
    [JsonPropertyName("prev_page")] public int? PrevPage { get; set; }
    [JsonPropertyName("next_page")] public int? NextPage { get; set; }
    [JsonPropertyName("last_page")] public int LastPage { get; set; }
    [JsonPropertyName("per_page")] public int PerPage { get; set; }
    [JsonPropertyName("total")] public int Total { get; set; }
}