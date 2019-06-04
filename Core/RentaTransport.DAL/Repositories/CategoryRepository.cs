using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.DAL.DAOs;
using RentaTransport.DAL.DataContexts;
using RentaTransport.DAL.Repositories.CrudRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaTransport.DAL.Repositories
{
   public class CategoryRepository : CrudRepository<CategoryDTO, CategoryDAO, MainDataContext>, ICategoryRepository
    {
        public CategoryRepository(MainDataContext ctx) : base(ctx)
        {
        }
    }
}
