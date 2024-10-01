using FinTrack.Application.Models.Response.Hateoas;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FinTrack.Application.Models.Response;

public class JsonResponse<T> : HateoasResponse
{
    [JsonIgnore]
    public Type Type
    {
        get => typeof(T);
    }

    [JsonPropertyName("operationId")]
    public Guid OperationId { get; set; }

    [JsonPropertyName("view")]
    public JsonElement View { get; set; }

    [JsonPropertyName("pendencia")]
    public JsonElement? Pendencia { get; set; }
}
