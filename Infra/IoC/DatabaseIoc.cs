﻿using Infra.Configurations.Environment;
using Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.IoC;

public static class DatabaseIoc
{
    public static void AddDatabase(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        var configurationMySQL = configuration.GetConnectionString(EnvironmentConstants.MySqlConfigName);
        serviceCollection.AddDbContext<BookContext>(options => options.UseMySQL(configurationMySQL));
    }
}