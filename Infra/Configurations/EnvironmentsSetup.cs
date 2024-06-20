using Infra.Configurations.Environment;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Configurations;

public static class EnvironmentsSetup
{
    public static void AddEnvironmentVariables(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.Configure<MySqlConfig>(configuration.GetSection(EnvironmentConstants.MySqlConfigName));
    }
}