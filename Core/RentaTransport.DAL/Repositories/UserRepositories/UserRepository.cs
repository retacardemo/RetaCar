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
using RentaTransport.Common.Resources;
using RentaTransport.Common.Responses;
using RentaTransport.DAL.DAOs;

namespace RentaTransport.DAL.Repositories.UserRepositories
{
    public class UserRepository: IUserRepository
    {
        private readonly UserManager<UserDao> _userManager;
        private readonly SignInManager<UserDao> _signInManager;

        public UserRepository(UserManager<UserDao> userManager, SignInManager<UserDao> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<ActionResponse<IQueryable<UserDto>>> GetAllAsync(params Enums.Status[] statuses)
        {
            try
            {
                var data = _userManager.Users.ProjectTo<UserDto>(Mapper.Configuration);
                return ActionResponse<IQueryable<UserDto>>.Succeed(data);
            }
            catch (Exception ex)
            {
                return ActionResponse<IQueryable<UserDto>>.Failure(ex.Message);
            }
        }

        public async Task<ActionResponse<UserDto>> GetByIdAsync(Guid id, Enums.Status status = Enums.Status.Active)
        {
            try
            {
                var entity = await _userManager.FindByIdAsync(id.ToString());
                if (entity == null)
                    return ActionResponse<UserDto>.Failure($"User not found for Id:{id.ToString()}");
                var dto = Mapper.Map<UserDto>(entity);
                return ActionResponse<UserDto>.Succeed(dto);
            }
            catch (Exception ex)
            {
                return ActionResponse<UserDto>.Failure(ex.Message);
            }
        }

        public async Task<ActionResponse<UserDto>> SaveAsync(UserDto obj)
        {
            try
            {
                IdentityResult response = null;
                var entity = Mapper.Map<UserDao>(obj);
                if (obj.Id == default(Guid))
                    response = await _userManager.CreateAsync(entity, entity.PasswordHash);
                else
                    response = await _userManager.UpdateAsync(entity);
                if (!response.Succeeded)
                    return ActionResponse<UserDto>.Failure(response.Errors.Select(e => e.Description).ToArray());
                var user = await _userManager.FindByEmailAsync(entity.Email);
                if (user == null)
                    return ActionResponse<UserDto>.Failure($"User not found for Email:{user.Email}");
                var dto = Mapper.Map<UserDto>(user);
                return ActionResponse<UserDto>.Succeed(dto);
            }
            catch (Exception ex)
            {
                return ActionResponse<UserDto>.Failure(ex.Message);
            }
        }

        public async Task<ActionResponse> RemoveAsync(Guid id)
        {
            try
            {
                var entity = await _userManager.FindByIdAsync(id.ToString());
                if (entity == null)
                    return ActionResponse.Failure($"User not found for Id:{id.ToString()}");
                var result = await _userManager.DeleteAsync(entity);
                if (!result.Succeeded)
                    return ActionResponse.Failure(result.Errors.Select(e => e.Description).ToArray());
                return ActionResponse.Succeed();
            }
            catch (Exception ex)
            {
                return ActionResponse.Failure(ex.Message);
            }
        }

        public async Task<ActionResponse> SignInAsync(string email, string password, bool rememberMe = false)
        {
            try
            {
                //signout existing login
                await _signInManager.SignOutAsync();
                //find user by email
                var user = await _userManager.FindByEmailAsync(email);
                if (user == null)
                {
                    return ActionResponse.Failure(UI.UserNotFound);
                }
                //signin with password
                var result = await _signInManager.PasswordSignInAsync(email, password, rememberMe, lockoutOnFailure: false);
                if (result.RequiresTwoFactor)
                {
                    return ActionResponse.Failure(UI.RequiresTwoFactor);
                }
                //check accout lockedout or not
                if (result.IsLockedOut)
                {
                    return ActionResponse.Failure(UI.UserAccountLockedOut);
                }
                //check signin 
                if (!result.Succeeded)
                {
                    return ActionResponse.Failure(UI.UserPasswordIncorrect);
                }
                return ActionResponse.Succeed();
            }
            catch (Exception ex)
            {
                return ActionResponse.Failure(ex.Message);
            }
        }

        public async Task<ActionResponse> SignOutAsync()
        {
            try
            {
                await _signInManager.SignOutAsync();
                return ActionResponse.Succeed();
            }
            catch (Exception ex)
            {
                return ActionResponse.Failure(ex.Message);
            }
        }

        public async Task<ActionResponse> GetTwoFactorAuthenticationUserAsync()
        {
            try
            {
                var user = await _signInManager.GetTwoFactorAuthenticationUserAsync();
                if (user == null)
                    throw new ApplicationException($"Unable to load two-factor authentication user.");
                return ActionResponse.Succeed();
            }
            catch (Exception ex)
            {
                return ActionResponse.Failure(ex.Message);
            }
        }
    }
}
