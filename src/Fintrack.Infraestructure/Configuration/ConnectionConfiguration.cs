using FinTrack.Infraestructure.Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FinTrack.Api.Configurations;

public static class ConnectionConfiguration
{
    public static IServiceCollection AddAppConnections(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbConnection(configuration);
        return services;
    }

    private static IServiceCollection AddDbConnection(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        var connectionString = configuration.GetConnectionString("FinTrackDb");

        services.AddDbContext<FinTrackDbContext>(
            options => options.UseMySql(
                connectionString,
                ServerVersion.AutoDetect(connectionString)
            )
        );

        return services;
    }
}
