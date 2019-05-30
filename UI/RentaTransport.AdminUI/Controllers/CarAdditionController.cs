using RentaTransport.AdminUI.Controllers.BaseControllers;
using RentaTransport.AdminUI.Models;
using RentaTransport.AdminUI.ServiceFacade;
using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Services;
using RentaTransport.BLL.Validators;

namespace RentaTransport.AdminUI.Controllers
{
    public class CarAdditionController : CrudController<CarAdditionViewModel, CarAdditionServiceFacade, CarAdditionDTO, ICarAdditionRepository, CarAdditionValidator, CarAdditionService>
    {
        public CarAdditionController(CarAdditionServiceFacade carAdditionServiceFacade):base(carAdditionServiceFacade)
        {
        }
    }
}