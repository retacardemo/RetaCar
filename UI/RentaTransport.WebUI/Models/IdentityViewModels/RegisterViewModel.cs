using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RentaTransport.Common.Resources;

namespace RentaTransport.WebUI.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(ResourceType = typeof(UI), Name = nameof(UI.Email))]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessageResourceType = typeof(UI), ErrorMessageResourceName = nameof(UI.PasswordMinimumLength), MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(ResourceType = typeof(UI), Name = nameof(UI.Password))]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(ResourceType = typeof(UI), Name = nameof(UI.ConfirmPassword))]
        [Compare(nameof(Password), ErrorMessageResourceType = typeof(UI), ErrorMessageResourceName = nameof(UI.PasswordNotConfirm))]
        public string ConfirmPassword { get; set; }
    }
}
