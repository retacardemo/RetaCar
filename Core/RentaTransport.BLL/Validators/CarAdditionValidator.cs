using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using RentaTransport.BLL.DTOs;

namespace RentaTransport.BLL.Validators
{
    public class CarAdditionValidator : BaseValidator<CarAdditionDTO>
    {
        public CarAdditionValidator()
        {
            RuleFor(m => m.Name).NotEmpty();
        }
    }
}
