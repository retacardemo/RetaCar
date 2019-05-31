using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Services;
using RentaTransport.BLL.Validators;

namespace RentaTransport.AdminUI.ServiceFacade
{
    public class FuelServiceFacade : CrudServiceFacade<FuelTypeDTO, IFuelTypeRepository, FuelTypeValidator, FuelTypeService>
    {
        public FuelServiceFacade(FuelTypeService service):base(service)
        {
        }
    }
}
