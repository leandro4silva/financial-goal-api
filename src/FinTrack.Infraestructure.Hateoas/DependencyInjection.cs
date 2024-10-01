using Fintrack.Infraestructure.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace FinTrack.Infraestructure.Hateoas;

[ExcludeFromCodeCoverage]
public static class DependencyInjection
{
    public static IServiceCollection AddHateoasApplicationLinks(this IServiceCollection services, AppConfiguration appConfigs)
    {
        return services;
    }
}
