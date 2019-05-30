using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using RentaTransport.BLL.DTOs;

namespace RentaTransport.BLL.Validators
{
    public class CarImageValidator : BaseValidator<CarImageDTO>
    {
        public CarImageValidator()
        {
            RuleFor(m => m.Name).NotEmpty();
            RuleFor(m => m.MimeType).NotEmpty();
            RuleFor(m => m.Photo).NotEmpty();
        }
    }
}
