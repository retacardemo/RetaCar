using RentaTransport.AdminUI.Controllers.BaseControllers;
using RentaTransport.AdminUI.Models;
using RentaTransport.AdminUI.ServiceFacade;
using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Services;
using RentaTransport.BLL.Validators;

namespace RentaTransport.AdminUI.Controllers
{
    public class FuelTypeController : CrudController<FuelViewModel,FuelServiceFacade,FuelTypeDTO,IFuelTypeRepository,FuelTypeValidator,FuelTypeService>
    {
        public FuelTypeController(FuelServiceFacade fuelServiceFacade):base(fuelServiceFacade)
        {
        }
    }
}