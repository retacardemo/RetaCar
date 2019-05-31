using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Validators.UserValidator;

namespace RentaTransport.BLL.Services
{
    public class RoleService : IdentityCrudService<RoleDto, IRoleRepository, RoleValidator>
    {
        public RoleService(IRoleRepository repository, RoleValidator validator) : base(repository, validator)
        {
        }
    }
}
