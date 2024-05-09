using System.Text.Json.Serialization;

namespace Diploma.Models;
public record Milestone
{
    [JsonPropertyName("id")] public int Id { get; set; }
    [JsonPropertyName("project_id")] public int Project_id { get; set; }
    [JsonPropertyName("root_id")] public int Root_id { get; set; }
    [JsonPropertyName("parent_id")] public int Parent_id { get; set; }
    [JsonPropertyName("name")] public string Name { get; set; }
}
