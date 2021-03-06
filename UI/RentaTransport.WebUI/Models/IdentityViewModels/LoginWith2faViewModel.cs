﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RentaTransport.Common.Resources;

namespace RentaTransport.WebUI.Models
{
    public class LoginWith2faViewModel
    {
        [Required]
        [StringLength(7, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Text)]
        [Display(ResourceType = typeof(UI),Name = nameof(UI.AuthenticatorCode))]
        public string TwoFactorCode { get; set; }

        [Display(ResourceType = typeof(UI), Name = nameof(UI.RememberThisMachine))]
        public bool RememberMachine { get; set; }

        public bool RememberMe { get; set; }
    }
}
