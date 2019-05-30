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
    public class BrandServiceFacade : CrudServiceFacade<BrandDTO,IBrandRepository,BrandValidator,BrandService>
    {
        public BrandServiceFacade(BrandService brandService):base(brandService)
        {
        }
    }
}
