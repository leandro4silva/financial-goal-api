using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;

namespace FinTrack.Infraestructure.Hateoas.Filters;

public class LinksResponseAttribute : Attribute, IFilterFactory
{
    public bool IsReusable => false;

    public IFilterMetadata CreateInstance(IServiceProvider serviceProvider)
    {
        if(serviceProvider is null) throw new ArgumentNullException(nameof(serviceProvider));
        return serviceProvider.GetRequiredService<LinksResponseFilterAsync>();
    }
}
