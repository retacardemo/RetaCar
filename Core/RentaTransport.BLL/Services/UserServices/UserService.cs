using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Validators.UserValidator;
using RentaTransport.Common.Responses;
using System.Threading.Tasks;

namespace RentaTransport.BLL.Services
{
    public class UserService : IdentityCrudService<UserDto, IUserRepository, UserValidator>
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository repository, UserValidator validator) : base(repository, validator)
        {
            _userRepository = repository;
        }

        public async Task<ActionResponse> SignInAsync(string email, string password, bool rememberMe = false)
        {
            var response = await _userRepository.SignInAsync(email, password, rememberMe);
            return response;
        }

        public async Task<ActionResponse> SignOutAsync()
        {
            var response = await _userRepository.SignOutAsync();
            return response;
        }

        public async Task<ActionResponse> GetTwoFactorAuthenticationUserAsync()
        {
            var response = await _userRepository.GetTwoFactorAuthenticationUserAsync();
            return response;
        }
    }
}
