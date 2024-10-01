using System.Text.Json.Serialization;

namespace FinTrack.Application.Models.Response.Hateoas;

public abstract class HateoasResponse
{
    [JsonPropertyName("_links")]
    public ICollection<HateoasLink>? Links { get; set; }
}
