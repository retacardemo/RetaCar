using RentaTransport.Common.Resources;
using System.ComponentModel.DataAnnotations;

namespace RentaTransport.AdminUI.Models
{
    public class CarAdditionViewModel:BaseViewModel
    {
        [Required(ErrorMessageResourceType = typeof(UI), ErrorMessageResourceName = nameof(UI.CannotBeEmpty))]
        public string Name { get; set; }

        [Required(ErrorMessageResourceType = typeof(UI), ErrorMessageResourceName = nameof(UI.CannotBeEmpty))]
        public string Description { get; set; }
    }
}
