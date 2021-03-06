﻿using FluentValidation;
using RentaTransport.BLL.DTOs;

namespace RentaTransport.BLL.Validators
{
    public class BrandValidator : BaseValidator<BrandDTO>
    {
        public BrandValidator()
        {
            RuleFor(m => m.Name).NotEmpty();
        }
    }
}
