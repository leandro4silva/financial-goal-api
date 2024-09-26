namespace FinTrack.Api.ApiModels;

public class ApiResponse<TData>
{
    public TData Data { get; set; }

    public ApiResponse(TData data)
    {
        Data = data;
    }
}
