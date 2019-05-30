using RentaTransport.BLL.DTOs;
using RentaTransport.Common.Responses;
using System;
using System.Linq;
using System.Threading.Tasks;
using static RentaTransport.Common.Constants.Enums;

namespace RentaTransport.BLL.Services
{
    public interface IBaseService<TDto> where TDto : BaseDTO
    {
        Task<ActionResponse<IQueryable<TDto>>> GetAllAsync(params Status[] statuses);
        Task<ActionResponse<TDto>> GetByIdAsync(Guid id);
        Task<ActionResponse> RemoveAsync(Guid id, Guid? userId = null);
        Task<ActionResponse> SaveAsync(TDto obj, Guid? userId = null);
    }

}
