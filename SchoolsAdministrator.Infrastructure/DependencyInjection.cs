using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SchoolsAdministrator.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Default");
        services.AddDbContext<DbContext>(options =>
        {
            options.UseSqlServer(connectionString, providerOptions => {
                providerOptions.CommandTimeout(240);
            });
        });

        return services;        
    }
}
