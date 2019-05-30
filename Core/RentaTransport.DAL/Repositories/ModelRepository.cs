using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.DAL.DAOs;
using RentaTransport.DAL.DataContexts;
using RentaTransport.DAL.Repositories.CrudRepositories;

namespace RentaTransport.DAL.Repositories
{
    public class ModelRepository: CrudRepository<ModelDTO, ModelDAO, MainDataContext>, IModelRepository
    {
        public ModelRepository(MainDataContext ctx): base(ctx)
        {
            
        }
    }
}
