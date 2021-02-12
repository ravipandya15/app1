using app1.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app1.Data
{
    public static class ApplicationExtension
    {
        public static IServiceCollection RegisterApplicationDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            RegisterDBContext(services, configuration);
            return services;
        }
        private static void RegisterDBContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddEntityFrameworkSqlServer()
                .AddDbContext<TestDBContext>(
                options =>
                {
                    options.UseSqlServer(
                        configuration["ConnectionStrings:TestDBConnection"],
                        sqlServerOptionsAction: sqlOptions =>
                        {
                            sqlOptions.EnableRetryOnFailure(maxRetryCount: 3, maxRetryDelay: TimeSpan.FromSeconds(2), errorNumbersToAdd: null);
                        });
                },
                ServiceLifetime.Scoped);
        }
    }
}
