using RentaTransport.Common.Responses;
using System;
using System.Linq;
using System.Threading.Tasks;
using static RentaTransport.Common.Constants.Enums;

namespace RentaTransport.BLL.Repositories.CrudRepositories
{
    public interface IIdentityCrudRepository<TDto> where TDto : class
    {
        Task<ActionResponse<IQueryable<TDto>>> GetAllAsync(params Status[] statuses);
        Task<ActionResponse<TDto>> GetByIdAsync(Guid id, Status status = Status.Active);
        Task<ActionResponse<TDto>> SaveAsync(TDto obj);
        Task<ActionResponse> RemoveAsync(Guid id);
    }
}
