using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace FinTrack.Infraestructure.Hateoas.Filters;

public class LinksResponseFilterAsync : IAsyncActionFilter
{
    private readonly ILogger<LinksResponseFilterAsync> _logger;

    public LinksResponseFilterAsync(ILogger<LinksResponseFilterAsync> logger)
    {
        _logger = logger;
    }

    public Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        throw new NotImplementedException();
    }
}
