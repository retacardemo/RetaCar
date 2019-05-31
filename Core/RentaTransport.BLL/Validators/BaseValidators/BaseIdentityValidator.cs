using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaTransport.BLL.Validators
{
    public class BaseIdentityValidator<TDto> : AbstractValidator<TDto>
        where TDto : class
    {
        public BaseIdentityValidator()
        {
        }
    }
}
