using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentaTransport.BLL.Repositories.CrudRepositories;
using RentaTransport.BLL.Services;
using RentaTransport.BLL.Validators;
using RentaTransport.Common.Constants;
using RentaTransport.Common.Responses;

namespace RentaTransport.WebUI.ServiceFacades.CrudServiceFacades
{
    public abstract class IdentityCrudServiceFacade<TDto, TRepository, TValidator, TService>
        where TDto : class
        where TRepository : IIdentityCrudRepository<TDto>
        where TValidator : BaseIdentityValidator<TDto>
        where TService : IdentityCrudService<TDto, TRepository, TValidator>
    {
        private readonly TService _service;

        public IdentityCrudServiceFacade(TService service)
        {
            _service = service;
        }

        public async Task<IQueryable<TDto>> GetAllAsync(params Enums.Status[] statuses)
        {
            var data = await _service.GetAllAsync(statuses);
            if (data.IsSucceed)
                return data.Data;
            return Enumerable.Empty<TDto>().AsQueryable();
        }

        public async Task<TDto> GetByIdAsync(Guid id, Enums.Status status = Enums.Status.None)
        {
            var dto = await _service.GetByIdAsync(id, status);
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
