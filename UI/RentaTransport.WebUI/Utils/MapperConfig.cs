using RentaTransport.BLL.DTOs;
using RentaTransport.WebUI.Models;

namespace RentaTransport.WebUI.Utils
{
    public class MapperConfig : AutoMapper.Profile
    {
        public MapperConfig()
        {
            AllowNullCollections = true;
            AllowNullDestinationValues = true;

            CreateMap<CityViewModel, CityDTO>().ReverseMap();
            CreateMap<CarViewModel, CarDTO>().ReverseMap();
            CreateMap<ColorViewModel, ColorDTO>().ReverseMap();
            CreateMap<BanTypeViewModel, BanTypeDTO>().ReverseMap();
            CreateMap<FuelTypeViewModel, FuelTypeDTO>().ReverseMap();
            CreateMap<BrandViewModel, BrandDTO>().ReverseMap();
            CreateMap<CarAdditionViewModel, CarAdditionDTO>().ReverseMap();
            CreateMap<CarImageViewModel, CarImageDTO>().ReverseMap();
            CreateMap<ModelViewModel, ModelDTO>().ReverseMap();
            CreateMap<CustomerPhoneNumberViewModel, CustomerPhoneNumberDTO>().ReverseMap();
        }
    }
}
