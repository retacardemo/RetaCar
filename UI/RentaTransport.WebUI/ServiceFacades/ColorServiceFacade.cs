using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Services;
using RentaTransport.BLL.Validators;

namespace RentaTransport.WebUI.ServiceFacades
{
    public class ColorServiceFacade : CrudServiceFacade<ColorDTO,IColorRepository,ColorValidator,ColorService>
    {
        public ColorServiceFacade(ColorService colorService):base(colorService)
        {
            
        }
    }
}
