using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Services;
using RentaTransport.BLL.Validators;

namespace RentaTransport.AdminUI.ServiceFacade
{
    public class BanTypeServiceFacade:CrudServiceFacade<BanTypeDTO,IBanTypeRepository,BanTypeValidator,BanTypeService>
    {
        public BanTypeServiceFacade(BanTypeService service):base(service)
        {
        }
    }
}
