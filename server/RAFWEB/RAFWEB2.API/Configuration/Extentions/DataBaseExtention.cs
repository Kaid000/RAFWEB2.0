using Microsoft.EntityFrameworkCore;
using RAFWEB2.Core.Context;

namespace RAFWEB2.API.Configuration.Extentions
{
    public static class DataBaseExtension

    {

        public static IServiceCollection AddPersistenceInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
        {
            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
