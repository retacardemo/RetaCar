using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories.CrudRepositories;

namespace RentaTransport.BLL.Repositories
{
    public interface IUserRoleRepository:IIdentityCrudRepository<UserRoleDto>
    {
    }
}
