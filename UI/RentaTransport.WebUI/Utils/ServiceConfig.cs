using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Services;
using RentaTransport.BLL.Validators;
using RentaTransport.DAL.Repositories;
using RentaTransport.WebUI.ServiceFacades;

namespace RentaTransport.WebUI.Utils
{
    public static class ServiceConfig
    {
        public static void Register(this IServiceCollection services)
        {
            RegisterServiceFacades(services);
            RegisterRepositories(services);
            RegisterServices(services);
            RegisterValidators(services);
            RegisterMappers();
        }

        private static void RegisterServiceFacades(IServiceCollection services)
        {
            services.AddScoped<CityServiceFacade>();
        }

        private static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<CityService>();
        }

        private static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<ICityRepository, CityRepository>();
        }

        private static void RegisterValidators(IServiceCollection services)
        {
            services.AddScoped<CityValidator>();
        }

        private static void RegisterMappers()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<MapperConfig>();
                cfg.AddProfile<DAL.DataContexts.MapperConfig>();
            });
        }
    }
}
