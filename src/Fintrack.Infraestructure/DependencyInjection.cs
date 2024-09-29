using FinTrack.Application.Interfaces;
using FinTrack.Domain.Repositories;
using FinTrack.Infraestructure.Data.EF.Repositories.v1;
using FinTrack.Infraestructure.Data.EF.UnitOfWork;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace Fintrack.Infraestructure;

[ExcludeFromCodeCoverage]
public static class DependencyInjection
{
    public static IServiceCollection AddInfra(this IServiceCollection services, IConfiguration configuration)
    {
        #region UnitOfWork
 
        services.AddTransient<IUnitOfWork, UnitOfWork>();
        
        #endregion

        #region Repository

        services.AddTransient<IGoalRepository, GoalRepository>();

        #endregion

        return services;
    }
}
