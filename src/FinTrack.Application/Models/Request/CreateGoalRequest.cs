using FinTrack.Domain.Enum;
using System.Text.Json.Serialization;

namespace FinTrack.Application.Models.Request;

public class CreateGoalRequest
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("goalAmount")]
    public decimal GoalAmount { get; set; }

    [JsonPropertyName("deadline")]
    public DateTime Deadline { get; set; }

    [JsonPropertyName("idealMontlySaving")]
    public decimal IdealMonthlySaving { get; set; }

    [JsonPropertyName("status")]
    public GoalStatus Status { get; set; }
}
