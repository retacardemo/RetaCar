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
    public class CarRepository: CrudRepository<CarDTO, CarDAO, MainDataContext>, ICarRepository
    {
        public CarRepository(MainDataContext ctx): base(ctx)
        {
            
        }
    }
}
