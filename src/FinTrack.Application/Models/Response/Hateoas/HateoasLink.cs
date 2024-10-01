using System.Text.Json.Serialization;

namespace FinTrack.Application.Models.Response.Hateoas;

public class HateoasLink
{
    [JsonPropertyName("href")]
    public string? Href { get; set; }

    [JsonPropertyName("rel")]
    public string? Rel { get; set; }

    [JsonPropertyName("method")]
    public string? Method { get; set; }
}
