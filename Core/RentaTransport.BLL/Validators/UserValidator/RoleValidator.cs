using FluentValidation;
using RentaTransport.BLL.DTOs;

namespace RentaTransport.BLL.Validators.UserValidator
{
    public class RoleValidator : BaseIdentityValidator<RoleDto>
    {
        public RoleValidator()
        {
            RuleFor(e => e.Name).NotNull().NotEmpty();
            RuleFor(e => e.Description).NotNull().NotEmpty();
        }
    }
}
