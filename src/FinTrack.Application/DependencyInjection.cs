using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace FinTrack.Application;

[ExcludeFromCodeCoverage]
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        #region definitions

        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        #endregion

        return services;
    }
}
