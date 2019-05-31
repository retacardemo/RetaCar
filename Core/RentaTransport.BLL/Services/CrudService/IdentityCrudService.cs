using RentaTransport.BLL.Repositories.CrudRepositories;
using RentaTransport.BLL.Validators;
using RentaTransport.Common.Constants;
using RentaTransport.Common.Responses;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RentaTransport.BLL.Services
{
    public class IdentityCrudService<TDto, TRepository, TValidator>
        where TDto : class
        where TRepository : IIdentityCrudRepository<TDto>
        where TValidator : BaseIdentityValidator<TDto>
    {
        private readonly TRepository _repository;
        private readonly TValidator _validator;

        public IdentityCrudService(TRepository repository, TValidator validator)
        {
            _repository = repository;
            _validator = validator;
        }

        public TDto GetNewObj()
        {
            return (TDto)Activator.CreateInstance(typeof(TDto));
        }

        public async Task<ActionResponse<IQueryable<TDto>>> GetAllAsync(params Enums.Status[] statuses)
        {
            var response = await _repository.GetAllAsync(statuses);
            return response;
        }

        public async Task<ActionResponse<TDto>> GetByIdAsync(Guid id, Enums.Status status = Enums.Status.None)
        {
            var response = await _repository.GetByIdAsync(id, status);
            return response;
        }

        public async Task<ActionResponse> RemoveAsync(Guid id)
        {
            var response = await _repository.RemoveAsync(id);
            return response;
        }

        public async Task<ActionResponse<TDto>> SaveAsync(TDto obj)
        {
            try
            {
                var valResult = await _validator.ValidateAsync(obj);
                if (valResult.IsValid)
                {
                    var response = await _repository.SaveAsync(obj);
                    return response;
                }
                var valErrors = valResult.Errors.Select(e => e.ErrorMessage).ToArray();
                return ActionResponse<TDto>.Failure(valErrors);
            }
            catch (Exception ex)
            {
                return ActionResponse<TDto>.Failure(ex.Message);
            }
        }
    }
}
