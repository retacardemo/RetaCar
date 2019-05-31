using RentaTransport.BLL.DTOs;
using RentaTransport.DAL.DAOs;

namespace RentaTransport.DAL.DataContexts
{
    public class MapperConfig: AutoMapper.Profile
    {
        public MapperConfig()
        {
            AllowNullCollections = true;
            AllowNullDestinationValues = true;

            #region ToDAO

            #region User
            CreateMap<UserDto, UserDao>();
            CreateMap<RoleDto, RoleDao>();
            #endregion

            CreateMap<CarDTO, CarDAO>();
            CreateMap<CarAdditionDTO, CarAdditionDAO>();
            CreateMap<CarImageDTO, CarImageDAO>();
            CreateMap<ColorDTO, ColorDAO>();
            CreateMap<BrandDTO, BrandDAO>();
            CreateMap<ModelDTO, ModelDAO>();
            CreateMap<FuelTypeDTO, FuelTypeDAO>();
            CreateMap<BanTypeDTO, BanTypeDAO>();
            CreateMap<CustomerPhoneNumberDTO, CustomerPhoneNumberDAO>();
            CreateMap<CityDTO, CityDAO>();

            #endregion

            #region ToDTO

            #region User
            CreateMap<UserDao, UserDto>();
            CreateMap<RoleDao, RoleDto>();
            #endregion

            CreateMap<CarDAO, CarDTO>();
            CreateMap<CarAdditionDAO, CarAdditionDTO>();
            CreateMap<CarImageDAO, CarImageDTO>();
            CreateMap<ColorDAO, ColorDTO>();
            CreateMap<BrandDAO, BrandDTO>();
            CreateMap<ModelDAO, ModelDTO>();
            CreateMap<FuelTypeDAO, FuelTypeDTO>();
            CreateMap<BanTypeDAO, BanTypeDTO>();
            CreateMap<CustomerPhoneNumberDAO, CustomerPhoneNumberDTO>();
            CreateMap<CityDAO, CityDTO>();

            #endregion
        }
    }
}
