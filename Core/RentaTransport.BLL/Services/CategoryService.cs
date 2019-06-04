using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaTransport.BLL.Services
{
   public class CategoryService : CrudService<CategoryDTO, ICategoryRepository, CategoryValidator>
    {
        public CategoryService(ICategoryRepository repository, CategoryValidator validator) : base(repository, validator)
        {
        }
    }
}
