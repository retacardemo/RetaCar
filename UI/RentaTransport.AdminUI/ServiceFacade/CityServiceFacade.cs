using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Services;
using RentaTransport.BLL.Validators;

namespace RentaTransport.AdminUI.ServiceFacade
{
    public class CityServiceFacade:CrudServiceFacade<CityDTO,ICityRepository,CityValidator,CityService>
    {
        public CityServiceFacade(CityService service):base(service)
        {
        }
    }
}
