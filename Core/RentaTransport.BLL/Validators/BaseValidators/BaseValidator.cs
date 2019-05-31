using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using RentaTransport.BLL.DTOs;

namespace RentaTransport.BLL.Validators
{
    public abstract class BaseValidator<TDto> : AbstractValidator<TDto> where TDto: BaseDTO
    {
        public BaseValidator()
        {
            
        }
    }
}
