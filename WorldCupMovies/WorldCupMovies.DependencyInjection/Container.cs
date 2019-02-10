using Microsoft.Extensions.DependencyInjection;
using System;
using WorldCupMovies.Domain.FilmeDomain;
using WorldCupMovies.Domain.FinalDomain;

namespace WorldCupMovies.DependencyInjection
{
    public static class Container
    {
        private static IServiceProvider _serviceProvider;

        private static IServiceCollection _services;

        public static T GetService<T>()
        {
            if (_services == null)
            {
                _services = RegisterServices();
            }

            if (_serviceProvider == null)
            {
                _serviceProvider = _services.BuildServiceProvider();
            }

            return _serviceProvider.GetService<T>();
        }

        public static IServiceCollection RegisterServices(IServiceCollection services = null)
        {
            _services = services ?? new ServiceCollection();

            // WorldCupMovies.Domain
            _services.AddScoped<IFilmeDomain, FilmeDomain>();
            _services.AddScoped<IFinalDomain, FinalDomain>();

            return _services;
        }
    }
}