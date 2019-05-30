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
    public class BanTypeServiceFacade :CrudServiceFacade<BanTypeDTO,IBanTypeRepository,BanTypeValidator,BanTypeService>
    {
        public BanTypeServiceFacade(BanTypeService banTypeService):base(banTypeService)
        {
            
        }
    }
}
