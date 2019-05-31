using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Services;
using RentaTransport.BLL.Validators.UserValidator;
using RentaTransport.Common.Responses;
using RentaTransport.WebUI.Controllers.BaseControllers;
using RentaTransport.WebUI.Models;
using RentaTransport.WebUI.ServiceFacades.CrudServiceFacades;

namespace RentaTransport.WebUI.ServiceFacades.UserServiceFacades
{
    public class UserServiceFacade : IdentityCrudServiceFacade<UserDto, IUserRepository, UserValidator, UserService>
    {
        private readonly UserService _userService;

        public UserServiceFacade(UserService userService) : base(userService)
        {
            _userService = userService;
        }

        public async Task<ViewResponse> Login(LoginViewModel model)
        {
            var response = new ViewResponse();
            var signInResult = await _userService.SignInAsync(model.Email, model.Password, model.RememberMe);
            if (!signInResult.IsSucceed)
                response.Failure(signInResult.FailureResult);
            return response;
        }

        public async Task<ViewResponse> Logout()
        {
            var response = new ViewResponse();
            var signOutResult = await _userService.SignOutAsync();
            if (!signOutResult.IsSucceed)
                response.Failure(signOutResult.FailureResult);
            return response;
        }

        public async Task<ViewResponse> GetTwoFactorAuthenticationUser()
        {
            var response = new ViewResponse();
            var getTwoFactorAuthUserResult = await _userService.GetTwoFactorAuthenticationUserAsync();
            if (!getTwoFactorAuthUserResult.IsSucceed)
                response.Failure(getTwoFactorAuthUserResult.FailureResult);
            return response;
        }
    }
}
