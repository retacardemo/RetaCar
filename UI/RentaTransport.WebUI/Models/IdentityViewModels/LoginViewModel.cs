using RentaTransport.Common.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentaTransport.WebUI.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessageResourceType = typeof(UI), ErrorMessageResourceName = nameof(UI.CannotBeEmpty))]
        [Display(ResourceType = typeof(UI), Name = nameof(UI.Email), Prompt = nameof(UI.Email))]
        [DataType(DataType.EmailAddress, ErrorMessage = "exp.: someone@gmail.com")]
        [EmailAddress(ErrorMessage = "Exp.: someone@gmail.com")]
        public string Email { get; set; }

        [Required(ErrorMessageResourceType = typeof(UI), ErrorMessageResourceName = nameof(UI.CannotBeEmpty))]
        [Display(ResourceType = typeof(UI), Name = nameof(UI.Password), Prompt = nameof(UI.Password))]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(ResourceType = typeof(UI),Name = nameof(UI.RememberMe))]
        public bool RememberMe { get; set; }
    }
}
