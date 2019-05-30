using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Services;
using RentaTransport.BLL.Validators;

namespace RentaTransport.AdminUI.ServiceFacade
{
    public class ColorServiceFacade : CrudServiceFacade<ColorDTO, IColorRepository, ColorValidator, ColorService>
    {
        public ColorServiceFacade(ColorService colorService):base(colorService)
        {
        }
    }
}
