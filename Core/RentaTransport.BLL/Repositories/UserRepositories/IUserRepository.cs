using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories.CrudRepositories;
using RentaTransport.Common.Responses;
using System.Threading.Tasks;

namespace RentaTransport.BLL.Repositories
{
    public interface IUserRepository:IIdentityCrudRepository<UserDto>
    {
        Task<ActionResponse> SignInAsync(string email, string password, bool rememberMe = false);
        Task<ActionResponse> SignOutAsync();
        Task<ActionResponse> GetTwoFactorAuthenticationUserAsync();
    }
}
