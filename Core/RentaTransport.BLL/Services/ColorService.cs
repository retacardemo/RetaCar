using System;
using System.Collections.Generic;
using System.Text;
using RentaTransport.BLL.DTOs;
using RentaTransport.BLL.Repositories;
using RentaTransport.BLL.Validators;

namespace RentaTransport.BLL.Services
{
    public class ColorService: CrudService<ColorDTO, IColorRepository, ColorValidator>
    {
        public ColorService(IColorRepository repository, ColorValidator validator) : base(repository, validator)
        {
        }
    }
}
