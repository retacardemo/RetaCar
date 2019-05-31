using FluentValidation;
using RentaTransport.BLL.DTOs;

namespace RentaTransport.BLL.Validators.UserValidator
{
    public class UserValidator : BaseIdentityValidator<UserDto>
    {
        public UserValidator()
        {
            RuleFor(e => e.FirstName).NotNull().NotEmpty();
            RuleFor(e => e.LastName).NotNull().NotEmpty();
            RuleFor(e => e.Email).NotNull().NotEmpty();
            RuleFor(e => e.UserName).NotNull().NotEmpty();
        }
    }
}
