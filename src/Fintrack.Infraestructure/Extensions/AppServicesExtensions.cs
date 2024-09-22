using FinTrack.Domain.Repositories;
using FinTrack.Infraestructure.Data.EF.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace Fintrack.Infraestructure.Extensions;

[ExcludeFromCodeCoverage]
public static class AppServicesExtensions
{
    public static IServiceCollection AddAppServices(this IServiceCollection services)
    {
        #region repositories

        services.AddTransient<IFinancialGoalRepository, FinancialGoalRepository>();

        #endregion

        return services;
    }
}
