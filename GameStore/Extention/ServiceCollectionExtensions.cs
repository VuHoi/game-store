using GameStore.Implementations;
using GameStore.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Extention
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
           
            return services;
        }
    }
}
