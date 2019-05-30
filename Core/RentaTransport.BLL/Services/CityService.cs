using System;
using System.Collections.Generic;
using System.Text;
using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Validators;

namespace RentaTransport.BLL.Services
{
    public class CityService: CrudService<CityDTO, ICityRepository, CityValidator>
    {
        public CityService(ICityRepository repository, CityValidator validator) : base(repository, validator)
        {
        }
    }
}
