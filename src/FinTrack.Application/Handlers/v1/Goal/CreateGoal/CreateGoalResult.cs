using System.Text.Json.Serialization;

namespace FinTrack.Application.Handlers.v1.Goal.CreateGoal;

public class CreateGoalResult
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }
}
