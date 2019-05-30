using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Services;
using RentaTransport.BLL.Validators;
using RentaTransport.AdminUI.Controllers.BaseControllers;
using RentaTransport.AdminUI.Models;
using RentaTransport.AdminUI.ServiceFacade;

namespace RentaTransport.AdminUI.Controllers
{
    public class BanTypeController : CrudController<BanTypeViewModel, BanTypeServiceFacade, BanTypeDTO, IBanTypeRepository, BanTypeValidator, BanTypeService>
    {
        public BanTypeController(BanTypeServiceFacade serviceFacade):base(serviceFacade)
        {
        }
    }
}