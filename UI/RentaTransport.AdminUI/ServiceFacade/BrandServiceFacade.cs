using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Services;
using RentaTransport.BLL.Validators;

namespace RentaTransport.AdminUI.ServiceFacade
{
    public class BrandServiceFacade:CrudServiceFacade<BrandDTO,IBrandRepository,BrandValidator,BrandService>
    {
        public BrandServiceFacade(BrandService brandService):base(brandService)
        {
        }
    }
}
