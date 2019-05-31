using RentaTransport.Common.Resources;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using RentaTransport.WebUI.Models;
using static RentaTransport.Common.Constants.Enums;

namespace RentaTransport.WebUI.Models
{
    public class UserViewModel : BaseViewModel
    {
        [Display(ResourceType =typeof(UI), Name =nameof(UI.FirstName), Prompt = nameof(UI.FirstName))]
        [Required(ErrorMessageResourceType = typeof(UI), ErrorMessageResourceName = nameof(UI.CannotBeEmpty))]
        public string FirstName { get; set; }

        [Display(ResourceType = typeof(UI), Name = nameof(UI.LastName), Prompt = nameof(UI.LastName))]
        [Required(ErrorMessageResourceType = typeof(UI), ErrorMessageResourceName = nameof(UI.CannotBeEmpty))]
        public string LastName { get; set; }

        [Display(ResourceType = typeof(UI), Name = nameof(UI.Email), Prompt = nameof(UI.Email))]
        [Required(ErrorMessageResourceType = typeof(UI), ErrorMessageResourceName = nameof(UI.CannotBeEmpty))]
        [DataType(DataType.EmailAddress, ErrorMessage = "exp.: someone@gmail.com")]
        [EmailAddress(ErrorMessage = "Exp.: someone@gmail.com")]
        public string Email { get; set; }

        [Display(ResourceType = typeof(UI), Name = nameof(UI.Password), Prompt = nameof(UI.Password))]
        [Required(ErrorMessageResourceType = typeof(UI), ErrorMessageResourceName = nameof(UI.CannotBeEmpty))]
        public string Password { get; set; }

    }
}
