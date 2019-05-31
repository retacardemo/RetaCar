using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RentaTransport.Common.Resources;

namespace RentaTransport.WebUI.Models
{
    public class LoginWithRecoveryCodeViewModel
    {
            [Required]
            [DataType(DataType.Text)]
            [Display(ResourceType = typeof(UI), Name = nameof(RecoveryCode))]
            public string RecoveryCode { get; set; }
    }
}
