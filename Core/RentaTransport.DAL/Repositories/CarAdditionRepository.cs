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
    public class CarAdditionRepository: CrudRepository<CarAdditionDTO, CarAdditionDAO, MainDataContext>, ICarAdditionRepository
    {
        public CarAdditionRepository(MainDataContext ctx): base(ctx)
        {
            
        }
    }
}
