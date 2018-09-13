using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Sandbox.DataLayer.Extensions
{
    public static class ServiceCollectionsDbExtensions
    {
        public static readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TestMakerFree;Integrated Security=True; MultipleActiveResultSets=True";

        public static IServiceCollection AddDataService(this IServiceCollection services)
        {
            services.AddEntityFrameworkSqlServer();

            // Add ApplicationDbContext.
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString), ServiceLifetime.Scoped
                );

            return services;
        }
    }
}
