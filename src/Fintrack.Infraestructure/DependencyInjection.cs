using FinTrack.Domain.Repositories;
using FinTrack.Infraestructure.Data.EF.Repositories.v1;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace Fintrack.Infraestructure;

[ExcludeFromCodeCoverage]
public static class DependencyInjection
{
    public static IServiceCollection AddInfra(this IServiceCollection services, IConfiguration configuration)
    {
        #region

        services.AddTransient<IGoalRepository, GoalRepository>();

        #endregion

        return services;
    }
}
