using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Services;
using RentaTransport.BLL.Validators;

namespace RentaTransport.WebUI.ServiceFacades
{
    public class ModelServiceFacade :CrudServiceFacade<ModelDTO,IModelRepository,ModelValidator,ModelService>
    {
        public ModelServiceFacade(ModelService modelService) : base(modelService) { }
    }
}
