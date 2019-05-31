using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Identity;
using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.Common.Constants;
using RentaTransport.Common.Responses;
using RentaTransport.DAL.DAOs;

namespace RentaTransport.DAL.Repositories.UserRepositories
{
    public class RoleRepository: IRoleRepository
    {
        private readonly RoleManager<RoleDao> _roleManager;

        public RoleRepository(RoleManager<RoleDao> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<ActionResponse<IQueryable<RoleDto>>> GetAllAsync(params Enums.Status[] statuses)
        {
            try
            {
                var data = _roleManager.Roles.ProjectTo<RoleDto>(Mapper.Configuration);
                return ActionResponse<IQueryable<RoleDto>>.Succeed(data);
            }
            catch (Exception ex)
            {
                return ActionResponse<IQueryable<RoleDto>>.Failure(ex.Message);
            }
        }

        public async Task<ActionResponse<RoleDto>> GetByIdAsync(Guid id, Enums.Status status = Enums.Status.Active)
        {
            try
            {
                var entity = await _roleManager.FindByIdAsync(id.ToString());
                if (entity == null)
                    return ActionResponse<RoleDto>.Failure($"Role not found for Id:{id.ToString()}");
                var dto = Mapper.Map<RoleDto>(entity);
                return ActionResponse<RoleDto>.Succeed(dto);
            }
            catch (Exception ex)
            {
                return ActionResponse<RoleDto>.Failure(ex.Message);
            }
        }

        public async Task<ActionResponse<RoleDto>> SaveAsync(RoleDto obj)
        {
            try
            {
                IdentityResult response = null;
                var entity = Mapper.Map<RoleDao>(obj);
                if (obj.Id == default(Guid))
                    response = await _roleManager.CreateAsync(entity);
                else
                    response = await _roleManager.UpdateAsync(entity);
                if (!response.Succeeded)
                    return ActionResponse<RoleDto>.Failure(response.Errors.Select(e => e.Description).ToArray());
                var role = await _roleManager.FindByIdAsync(entity.Id.ToString());
                if (role == null)
                    return ActionResponse<RoleDto>.Failure($"Role not found for Id:{role.Id}");
                var dto = Mapper.Map<RoleDto>(role);
                return ActionResponse<RoleDto>.Succeed(dto);

            }
            catch (Exception ex)
            {
                return ActionResponse<RoleDto>.Failure(ex.Message);
            }
        }

        public async Task<ActionResponse> RemoveAsync(Guid id)
        {
            try
            {
                var entity = await _roleManager.FindByIdAsync(id.ToString());
                if (entity == null)
                    return ActionResponse.Failure($"Role not found for Id:{id.ToString()}");
                var response = await _roleManager.DeleteAsync(entity);
                return ActionResponse<RoleDto>.Succeed();
            }
            catch (Exception ex)
            {
                return ActionResponse<RoleDto>.Failure(ex.Message);
            }
        }
    }
}
