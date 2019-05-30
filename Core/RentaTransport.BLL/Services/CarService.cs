using System;
using System.Collections.Generic;
using System.Text;
using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Validators;

namespace RentaTransport.BLL.Services
{
    public class CarService: CrudService<CarDTO, ICarRepository, CarValidator>
    {
        public CarService(ICarRepository repository, CarValidator validator) : base(repository, validator)
        {
        }
    }
}
