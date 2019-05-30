using System;
using System.Collections.Generic;
using System.Text;
using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.DAL.DAOs;
using RentaTransport.DAL.DataContexts;
using RentaTransport.DAL.Repositories.CrudRepositories;

namespace RentaTransport.DAL.Repositories
{
    public class CityRepository: CrudRepository<CityDTO, CityDAO, MainDataContext>, ICityRepository
    {
        public CityRepository(MainDataContext ctx): base(ctx)
        {
            
        }
    }
}
