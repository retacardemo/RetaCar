using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Services;
using RentaTransport.BLL.Validators;
using RentaTransport.Common.Constants;
using RentaTransport.DAL.Repositories;

namespace RentaTransport.WebUI.ServiceFacades
{
    public class CityServiceFacade : CrudServiceFacade<CityDTO, ICityRepository, CityValidator, CityService>
    {
        public CityServiceFacade(CityService cityService) : base(cityService) { }
    }
}
