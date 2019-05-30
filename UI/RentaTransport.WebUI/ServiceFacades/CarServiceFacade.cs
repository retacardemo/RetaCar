using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Services;
using RentaTransport.BLL.Validators;
using RentaTransport.Common.Constants;
using RentaTransport.Common.Responses;

namespace RentaTransport.WebUI.ServiceFacades
{
    public class CarServiceFacade : CrudServiceFacade<CarDTO,ICarRepository,CarValidator,CarService>
    {
        public CarServiceFacade(CarService carService) : base(carService) { }
    }
}
