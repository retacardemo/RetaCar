using RentaTransport.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories.CrudRepositories;
using RentaTransport.BLL.Validators;
using static RentaTransport.Common.Constants.Enums;
using RentaTransport.Common.Responses;

namespace RentaTransport.WebUI.ServiceFacades
{
    public abstract class CrudServiceFacade<TDto, TRepository, TValidator, TService>
    where  TDto : BaseDTO
    where TRepository : ICrudRepository<TDto>
    where TValidator : BaseValidator<TDto>
    where TService : CrudService<TDto, TRepository, TValidator>
    {
        private readonly TService _service;

        public CrudServiceFacade(TService service)
        {
            _service = service;
        }

        public async Task<IQueryable<TDto>> GetAllAsync(params Status[] statuses)
        {
            var data = await _service.GetAllAsync(statuses);
            if (data.IsSucceed)
                return data.Data;
            return Enumerable.Empty<TDto>().AsQueryable();
        }

        public async Task<TDto> GetByIdAsync(Guid id)
        {
            var dto = await _service.GetByIdAsync(id);
            if (dto.IsSucceed)
                return dto.Data;
            return _service.GetNewObj();
        }

        public async Task<ViewResponse> RemoveAsync(Guid id)
        {
            var response = new ViewResponse();
            var actionResponse = await _service.RemoveAsync(id);
            if (!actionResponse.IsSucceed)
                response.Failure(actionResponse.FailureResult);
            return response;
        }

        public async Task<ViewResponse> SaveAsync(TDto obj)
        {
            var response = new ViewResponse();
            var actionResponse = await _service.SaveAsync(obj);
            if (!actionResponse.IsSucceed)
                response.Failure(actionResponse.FailureResult);
            return response;
        }
    }
}
