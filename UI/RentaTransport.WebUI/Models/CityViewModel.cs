﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentaTransport.WebUI.Models.BaseViewModels;

namespace RentaTransport.WebUI.Models
{
    public class CityViewModel: BaseViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
