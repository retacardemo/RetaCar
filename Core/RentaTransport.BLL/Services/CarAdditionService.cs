using System;
using System.Collections.Generic;
using System.Text;
using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Validators;

namespace RentaTransport.BLL.Services
{
    public class CarAdditionService : CrudService<CarAdditionDTO, ICarAdditionRepository, CarAdditionValidator>
    {
        public CarAdditionService(ICarAdditionRepository repository, CarAdditionValidator validator) : base(repository, validator)
        {
        }
    }
}
