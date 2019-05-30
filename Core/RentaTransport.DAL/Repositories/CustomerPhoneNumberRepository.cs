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
    public class CustomerPhoneNumberRepository : CrudRepository<CustomerPhoneNumberDTO, CustomerPhoneNumberDAO, MainDataContext>, ICustomerPhoneNumberRepository
    {
        public CustomerPhoneNumberRepository(MainDataContext ctx) : base(ctx)
        {

        }
    }
}
