using System;
using System.Collections.Generic;
using System.Text;
using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Validators;

namespace RentaTransport.BLL.Services
{
    public class BrandService: CrudService<BrandDTO, IBrandRepository, BrandValidator>
    {
        public BrandService(IBrandRepository repository, BrandValidator validator) : base(repository, validator)
        {
        }
    }
}
