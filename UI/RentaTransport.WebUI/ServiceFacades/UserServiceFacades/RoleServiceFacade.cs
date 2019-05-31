using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Services;
using RentaTransport.BLL.Validators.UserValidator;
using RentaTransport.WebUI.ServiceFacades.CrudServiceFacades;

namespace RentaTransport.WebUI.ServiceFacades.UserServiceFacades
{
    public class RoleServiceFacade : IdentityCrudServiceFacade<RoleDto, IRoleRepository, RoleValidator, RoleService>
    {
        public RoleServiceFacade(RoleService service) : base(service)
        {
        }
    }
}
