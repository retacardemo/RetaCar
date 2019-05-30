using RentaTransport.AdminUI.Controllers.BaseControllers;
using RentaTransport.AdminUI.Models;
using RentaTransport.AdminUI.ServiceFacade;
using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Services;
using RentaTransport.BLL.Validators;
namespace RentaTransport.AdminUI.Controllers
{
    public class ModelController : CrudController<ModelViewModel,ModelServiceFacade,ModelDTO,IModelRepository,ModelValidator,ModelService>
    {
        public ModelController(ModelServiceFacade modelServiceFacade):base(modelServiceFacade)
        {
        }
    }
}