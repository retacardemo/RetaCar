using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Services;
using RentaTransport.BLL.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentaTransport.AdminUI.ServiceFacade
{
    public class CarAdditionServiceFacade:CrudServiceFacade<CarAdditionDTO,ICarAdditionRepository,CarAdditionValidator,CarAdditionService>
    {
        public CarAdditionServiceFacade(CarAdditionService carAdditionService):base(carAdditionService)
        {
        }
    }
}
