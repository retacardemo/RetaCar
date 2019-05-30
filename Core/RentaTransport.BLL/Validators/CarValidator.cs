using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using RentaTransport.BLL.DTOs;

namespace RentaTransport.BLL.Validators
{
    public class CarValidator: BaseValidator<CarDTO>
    {
        public CarValidator()
        {
            RuleFor(m => m.Transmission).NotEmpty();
            RuleFor(m => m.BanTypeId).NotEmpty().Must(x => x != default(Guid));
            RuleFor(m => m.BrandId).NotEmpty().Must(x => x != default(Guid));
            RuleFor(m => m.CarAdditionId).NotEmpty().Must(x => x != default(Guid));
            RuleFor(m => m.CarImageId).NotEmpty().Must(x => x != default(Guid));
            RuleFor(m => m.CityId).NotEmpty().Must(x => x != default(Guid));
            RuleFor(m => m.ColorId).NotEmpty().Must(x => x != default(Guid));
            RuleFor(m => m.FuelTypeId).NotEmpty().Must(x => x != default(Guid));
            RuleFor(m => m.ModelId).NotEmpty().Must(x => x != default(Guid));
            RuleFor(m => m.CarEngine).NotEmpty();
            RuleFor(m => m.CarGear).NotEmpty();
            RuleFor(m => m.DrivingDistance).NotEmpty();
            RuleFor(m => m.Price).NotEmpty();
        }
    }
}
