using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using RentaTransport.BLL.DTOs;

namespace RentaTransport.BLL.Validators
{
    public class CityValidator: BaseValidator<CityDTO>
    {
        public CityValidator()
        {
            RuleFor(m => m.Name).NotEmpty();
        }
    }
}
