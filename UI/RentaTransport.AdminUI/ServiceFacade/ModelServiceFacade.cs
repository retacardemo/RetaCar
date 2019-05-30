using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Services;
using RentaTransport.BLL.Validators;

namespace RentaTransport.AdminUI.ServiceFacade
{
    public class ModelServiceFacade : CrudServiceFacade<ModelDTO, IModelRepository, ModelValidator, ModelService>
    {
        public ModelServiceFacade(ModelService modelService):base(modelService)
        {
        }
    }
}
