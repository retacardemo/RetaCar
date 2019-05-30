using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories.CrudRepositories;
using static RentaTransport.Common.Constants.Enums;
using RentaTransport.Common.Resources;
using RentaTransport.Common.Responses;
using RentaTransport.DAL.DAOs;

namespace RentaTransport.DAL.Repositories.CrudRepositories
{
    public abstract class CrudRepository<TDto, TDao, TContext> : ICrudRepository<TDto>
        where TDto : BaseDTO
        where TDao : BaseDAO
        where TContext : DbContext
    {
        private readonly TContext _ctx;

        public CrudRepository(TContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<ActionResponse<IQueryable<TDto>>> GetAllAsync(params Status[] statuses)
        {
            try
            {
                var entities = _ctx.Set<TDao>()
                    .Where(e => statuses.Count() == 0 || statuses.Contains(e.Status))
                    .ProjectTo<TDto>(Mapper.Configuration);
                return ActionResponse<IQueryable<TDto>>.Succeed(entities);
            }
            catch (Exception ex)
            {
                return ActionResponse<IQueryable<TDto>>.Failure(ex.Message);
            }
        }

        public async Task<ActionResponse<TDto>> GetByIdAsync(Guid id, Status status = Status.None)
        {
            try
            {
                var entity = await _ctx.Set<TDao>()
                    .FirstOrDefaultAsync(e => e.Id == id && (status == Status.None || e.Status == status));
                if (entity == null)
                    return ActionResponse<TDto>.Failure(UI.DataNotFound);
                var dto = Mapper.Map<TDto>(entity);
                return ActionResponse<TDto>.Succeed(dto);
            }
            catch (Exception ex)
            {
                return ActionResponse<TDto>.Failure(ex.Message);
            }
        }

        public async Task<ActionResponse> RemoveAsync(Guid id)
        {
            try
            {
                var data = await _ctx.Set<TDao>().FindAsync(id);
                data.Status = Status.Deleted;
                var result = await _ctx.SaveChangesAsync();
                return ActionResponse.Succeed();
            }
            catch (Exception ex)
            {
                return ActionResponse.Failure(ex.Message);
            }
        }

        public async Task<ActionResponse<TDto>> SaveAsync(TDto obj)
        {
            if (obj.Id == default(Guid))
                return await AddAsync(obj);
            return await UpdateAsync(obj);
        }

        private async Task<ActionResponse<TDto>> AddAsync(TDto obj)
        {
            try
            {
                var model = Mapper.Map<TDao>(obj);
                model.CreatedDate = DateTime.UtcNow.AddHours(4);
                using (var transaction = await _ctx.Database.BeginTransactionAsync())
                {
                    await _ctx.Set<TDao>().AddAsync(model);
                    var result = await _ctx.SaveChangesAsync();
                    transaction.Commit();
                    obj.Id = model.Id;
                    return ActionResponse<TDto>.Succeed(obj);
                }
            }
            catch (Exception ex)
            {
                return ActionResponse<TDto>.Failure(ex.Message);
            }
        }

        private async Task<ActionResponse<TDto>> UpdateAsync(TDto obj)
        {
            try
            {
                var model = Mapper.Map<TDao>(obj);
                using (var transaction = await _ctx.Database.BeginTransactionAsync())
                {
                    var dbModel = await _ctx.Set<TDao>().FirstOrDefaultAsync(x => x.Id == model.Id);
                    var entry = _ctx.Entry(dbModel);
                    entry.CurrentValues.SetValues(model);
                    entry.Property(x => x.CreatedDate).IsModified = false;
                    await _ctx.SaveChangesAsync();
                    transaction.Commit();
                    obj.Id = model.Id;
                    return ActionResponse<TDto>.Succeed(obj);
                }
            }
            catch (Exception ex)
            {
                return ActionResponse<TDto>.Failure(ex.Message);
            }
        }
    }
}
