using System.ComponentModel.DataAnnotations;
using RentaTransport.Common.Resources;
using RentaTransport.WebUI.Models;

namespace RentaTransport.WebUI.Models
{
    public class RoleViewModel : BaseViewModel
    {
        [Display(ResourceType = typeof(UI), Name = nameof(UI.Name), Prompt = nameof(UI.Name))]
        [Required(ErrorMessageResourceType = typeof(UI), ErrorMessageResourceName = nameof(UI.CannotBeEmpty))]
        public string Name { get; set; }

        [Display(ResourceType = typeof(UI), Name = nameof(UI.Description), Prompt = nameof(UI.Description))]
        [Required(ErrorMessageResourceType = typeof(UI), ErrorMessageResourceName = nameof(UI.CannotBeEmpty))]
        public string Description { get; set; }
    }
}
