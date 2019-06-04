using FluentValidation;
using RentaTransport.BLL.DTOs;

namespace RentaTransport.BLL.Validators
{
    public class CategoryValidator : BaseValidator<CategoryDTO>
    {
        public CategoryValidator()
        {
            RuleFor(m => m.Name).NotEmpty();
        }
    }
}
