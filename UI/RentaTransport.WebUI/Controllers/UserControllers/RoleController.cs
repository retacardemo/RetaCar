using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public class RoleController : IdentityCrudController<RoleViewModel, RoleServiceFacade, RoleDto, IRoleRepository, RoleValidator, RoleService>
    {
        public RoleController(RoleServiceFacade serviceFacade) : base(serviceFacade)
        {
        }
    }
}