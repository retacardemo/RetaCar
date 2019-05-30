using System;
using System.Collections.Generic;
using System.Text;
using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Validators;

namespace RentaTransport.BLL.Services
{
    public class CarImageService : CrudService<CarImageDTO, ICarImageRepository, CarImageValidator>
    {
        public CarImageService(ICarImageRepository repository, CarImageValidator validator) : base(repository, validator)
        {
        }
    }
}
