using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Services;
using RentaTransport.BLL.Validators;
using RentaTransport.BLL.Validators.UserValidator;
using RentaTransport.DAL.Repositories;
using RentaTransport.DAL.Repositories.UserRepositories;
using RentaTransport.WebUI.ServiceFacades;
using RentaTransport.WebUI.ServiceFacades.UserServiceFacades;

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
            services.AddScoped<UserServiceFacade>();
            services.AddScoped<RoleServiceFacade>();

            services.AddScoped<CityServiceFacade>();
            services.AddScoped<CarServiceFacade>();
            services.AddScoped<ModelServiceFacade>();
            services.AddScoped<CarAdditionServiceFacade>();
            services.AddScoped<CarImageServiceFacade>();
            services.AddScoped<BrandServiceFacade>();
            services.AddScoped<BanTypeServiceFacade>();
            services.AddScoped<FuelTypeServiceFacade>();
            services.AddScoped<CustomerPhoneNumberServiceFacade>();
            services.AddScoped<ColorServiceFacade>();
        }

        private static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<UserService>();
            services.AddScoped<RoleService>();

            services.AddScoped<CityService>();
            services.AddScoped<CarService>();
            services.AddScoped<ModelService>();
            services.AddScoped<CarAdditionService>();
            services.AddScoped<CarImageService>();
            services.AddScoped<BrandService>();
            services.AddScoped<BanTypeService>();
            services.AddScoped<FuelTypeService>();
            services.AddScoped<CustomerPhoneNumberService>();
            services.AddScoped<ColorService>();
        }

        private static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();

            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<ICarImageRepository, CarImageRepository>();
            services.AddScoped<ICarAdditionRepository, CarAdditionRepository>();
            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<IModelRepository, ModelRepository>();
            services.AddScoped<IColorRepository, ColorRepository>();
            services.AddScoped<IFuelTypeRepository, FuelTypeRepository>();
            services.AddScoped<IBanTypeRepository, BanTypeRepository>();
            services.AddScoped<ICustomerPhoneNumberRepository, CustomerPhoneNumberRepository>();
        }

        private static void RegisterValidators(IServiceCollection services)
        {
            services.AddScoped<UserValidator>();
            services.AddScoped<RoleValidator>();

            services.AddScoped<CityValidator>();
            services.AddScoped<CarValidator>();
            services.AddScoped<CarAdditionValidator>();
            services.AddScoped<CarImageValidator>();
            services.AddScoped<ModelValidator>();
            services.AddScoped<BrandValidator>();
            services.AddScoped<ColorValidator>();
            services.AddScoped<FuelTypeValidator>();
            services.AddScoped<BanTypeValidator>();
            services.AddScoped<CustomerPhoneNumberValidator>();
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
