using System;
using System.Collections.Generic;
using System.Text;
using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Validators;

namespace RentaTransport.BLL.Services
{
    public class FuelTypeService: CrudService<FuelTypeDTO, IFuelTypeRepository, FuelTypeValidator>
    {
        public FuelTypeService(IFuelTypeRepository repository, FuelTypeValidator validator) : base(repository, validator)
        {
        }
    }
}
