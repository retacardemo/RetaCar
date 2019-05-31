using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using RentaTransport.AdminUI.ServiceFacade;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Services;
using RentaTransport.BLL.Validators;
using RentaTransport.DAL.Repositories;

namespace RentaTransport.AdminUI.Utils
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
            //services.AddScoped<IdentityConfig>();
        }

        private static void RegisterServiceFacades(IServiceCollection services)
        {
            services.AddScoped<CityServiceFacade>();
            services.AddScoped<CarAdditionServiceFacade>();
            services.AddScoped<BanTypeServiceFacade>();
            services.AddScoped<ColorServiceFacade>();
            services.AddScoped<BrandServiceFacade>();
            services.AddScoped<ModelServiceFacade>();
            services.AddScoped<FuelServiceFacade>();
        }

        private static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<CityService>();
            services.AddScoped<CarAdditionService>();
            services.AddScoped<BanTypeService>();
            services.AddScoped<ColorService>();
            services.AddScoped<BrandService>();
            services.AddScoped<ModelService>();
            services.AddScoped<FuelTypeService>();
        }

        private static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<ICarAdditionRepository, CarAdditionRepository>();
            services.AddScoped<IBanTypeRepository, BanTypeRepository>();
            services.AddScoped<IColorRepository, ColorRepository>();
            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<IModelRepository, ModelRepository>();
            services.AddScoped<IFuelTypeRepository, FuelTypeRepository>();
        }

        private static void RegisterValidators(IServiceCollection services)
        {
            services.AddScoped<CityValidator>();
            services.AddScoped<CarAdditionValidator>();
            services.AddScoped<BanTypeValidator>();
            services.AddScoped<ColorValidator>();
            services.AddScoped<BrandValidator>();
            services.AddScoped<ModelValidator>();
            services.AddScoped<FuelTypeValidator>();
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
