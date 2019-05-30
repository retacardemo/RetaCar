using System;
using System.Collections.Generic;
using System.Text;
using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Validators;

namespace RentaTransport.BLL.Services
{
    public class BanTypeService : CrudService<BanTypeDTO, IBanTypeRepository, BanTypeValidator>
    {
        public BanTypeService(IBanTypeRepository repository, BanTypeValidator validator) : base(repository, validator)
        {
        }
    }
}
