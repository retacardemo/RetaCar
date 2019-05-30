using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Validators;
using RentaTransport.Common.Responses;
using System;
using System.Linq;
using System.Threading.Tasks;
using RentaTransport.BLL.Repositories.CrudRepositories;
using static RentaTransport.Common.Constants.Enums;

namespace RentaTransport.BLL.Services
{
    public abstract class CrudService<TDto, TRepository, TValidator>
          where TDto : BaseDTO
          where TRepository : ICrudRepository<TDto>
          where TValidator : BaseValidator<TDto>
    {
        private readonly TRepository _repository;
        private readonly TValidator _validator;

        public CrudService(TRepository repository, TValidator validator)
        {
            _repository = repository;
            _validator = validator;
        }

        public TDto GetNewObj()
        {
            return (TDto)Activator.CreateInstance(typeof(TDto));
        }

        public async Task<ActionResponse<IQueryable<TDto>>> GetAllAsync(params Status[] statuses)
        {
            var data = await _repository.GetAllAsync(statuses);
            return data;
        }

        public async Task<ActionResponse<TDto>> GetByIdAsync(Guid id)
        {
            var data = await _repository.GetByIdAsync(id);
            return data;
        }

        public async Task<ActionResponse> RemoveAsync(Guid id)
        {
            var response = await _repository.RemoveAsync(id);
            return response;
        }

        public virtual async Task<ActionResponse<TDto>> SaveAsync(TDto obj, Status status = Status.Active)
        {
            try
            {
                var valResult = await _validator.ValidateAsync(obj);
                if (valResult.IsValid)
                {
                    var response = await _repository.SaveAsync(obj);
                    //return succeed response ...
                    return response;
                }
                //get validation error results
                var valErrors = valResult.Errors.Select(e => e.ErrorMessage).ToArray();
                //return validation error results in failure response
                return ActionResponse<TDto>.Failure(valErrors);
            }
            catch (Exception ex)
            {
                //return catching errors in failure response
                return ActionResponse<TDto>.Failure(ex.Message);
            }
        }
    
    }
}
