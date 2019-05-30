using RentaTransport.AdminUI.Controllers.BaseControllers;
using RentaTransport.AdminUI.Models;
using RentaTransport.AdminUI.ServiceFacade;
using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Services;
using RentaTransport.BLL.Validators;

namespace RentaTransport.AdminUI.Controllers
{
    public class ColorController : CrudController<ColorViewModel, ColorServiceFacade, ColorDTO, IColorRepository, ColorValidator, ColorService>
    {
        public ColorController(ColorServiceFacade colorService):base(colorService)
        {
        }
    }
}