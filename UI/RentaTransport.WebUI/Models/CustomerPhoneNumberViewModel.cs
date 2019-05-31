﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentaTransport.WebUI.Models;

namespace RentaTransport.WebUI.Models
{
    public class CustomerPhoneNumberViewModel: BaseViewModel
    {
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
    }
}
