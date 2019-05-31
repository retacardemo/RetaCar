using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Services;
using RentaTransport.BLL.Validators.UserValidator;
using RentaTransport.WebUI.Controllers.BaseControllers;
using RentaTransport.WebUI.Models;
using RentaTransport.WebUI.ServiceFacades.UserServiceFacades;

namespace RentaTransport.WebUI.Controllers.UserControllers
{
    [Authorize(Roles = "UserManager")]
    public class UserController : IdentityCrudController<UserViewModel, UserServiceFacade, UserDto, IUserRepository, UserValidator, UserService>
    {
        public UserController(UserServiceFacade serviceFacade) : base(serviceFacade)
        {
        }
    }
}