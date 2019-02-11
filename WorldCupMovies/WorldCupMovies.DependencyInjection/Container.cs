using Microsoft.Extensions.DependencyInjection;
using System;
using WorldCupMovies.Services.CampeonatoService;
using WorldCupMovies.Services.FilmeService;

namespace WorldCupMovies.DependencyInjection
{
    public static class Container
    {
        private static IServiceProvider _serviceProvider;

        public static T GetService<T>()
        {
            return _serviceProvider.GetService<T>();
        }

        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IFilmeService, FilmeService>();
            services.AddScoped<ICampeonatoService, CampeonatoService>();
            _serviceProvider = services.BuildServiceProvider();
        }
    }
}