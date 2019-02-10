using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WorldCupMovies.DependencyInjection;

namespace WorldCupMovies.ApplicationService.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDependencyInjectionCustom(this IServiceCollection services, IConfiguration configuration)
        {
            Container.RegisterServices(services);
        }
    }
}
