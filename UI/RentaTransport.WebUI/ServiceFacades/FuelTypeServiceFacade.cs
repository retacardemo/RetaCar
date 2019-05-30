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
    public class FuelTypeServiceFacade :CrudServiceFacade<FuelTypeDTO,IFuelTypeRepository,FuelTypeValidator,FuelTypeService>
    {
        public FuelTypeServiceFacade(FuelTypeService fuelTypeService):base(fuelTypeService)
        {
            
        }
    }
}
