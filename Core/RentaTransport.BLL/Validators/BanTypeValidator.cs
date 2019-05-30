using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using RentaTransport.BLL.DTOs;

namespace RentaTransport.BLL.Validators
{
    public class BanTypeValidator: BaseValidator<BanTypeDTO>
    {
        public BanTypeValidator()
        {
            RuleFor(m => m.Name).NotEmpty();
        }
    }
}
