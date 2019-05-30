using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentaTransport.BLL.DTOs;
using static RentaTransport.Common.Constants.Enums;
using RentaTransport.Common.Responses;

namespace RentaTransport.BLL.Repositories.CrudRepositories
{
    public interface ICrudRepository<TDto> where TDto : BaseDTO
    {
        Task<ActionResponse<IQueryable<TDto>>> GetAllAsync(params Status[] statuses);
        Task<ActionResponse<TDto>> GetByIdAsync(Guid id, Status status = Status.None);
        Task<ActionResponse<TDto>> SaveAsync(TDto obj);
        Task<ActionResponse> RemoveAsync(Guid id);
    }
}
