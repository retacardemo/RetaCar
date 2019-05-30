using System;
using System.Collections.Generic;
using System.Text;
using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Validators;

namespace RentaTransport.BLL.Services
{
    public class ModelService: CrudService<ModelDTO, IModelRepository, ModelValidator>
    {
        public ModelService(IModelRepository repository, ModelValidator validator) : base(repository, validator)
        {
        }
    }
}
