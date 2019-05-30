﻿using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using RentaTransport.BLL.DTOs;

namespace RentaTransport.BLL.Validators
{
    public class ModelValidator: BaseValidator<ModelDTO>
    {
        public ModelValidator()
        {
            RuleFor(m => m.Name).NotEmpty();
        }
    }
}
