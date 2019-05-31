using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.Common.Constants;
using RentaTransport.Common.Responses;
using RentaTransport.DAL.DAOs;

namespace RentaTransport.DAL.Repositories.UserRepositories
{
    public class UserRoleRepository: IUserRoleRepository
    {
        private readonly UserManager<UserDao> _userManager;
        private readonly RoleManager<RoleDao> _roleManager;

        public UserRoleRepository(RoleManager<RoleDao> roleManager, UserManager<UserDao> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task<ActionResponse<IQueryable<UserRoleDto>>> GetAllAsync(params Enums.Status[] statuses)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                return ActionResponse<IQueryable<UserRoleDto>>.Failure(ex.Message);
            }
        }

        public async Task<ActionResponse<UserRoleDto>> GetByIdAsync(Guid id, Enums.Status status = Enums.Status.Active)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResponse<UserRoleDto>> SaveAsync(UserRoleDto obj)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResponse> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
