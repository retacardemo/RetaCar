using RentaTransport.Common.Resources;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentaTransport.AdminUI.Models
{
    public class BrandViewModel:BaseViewModel
    {
        public BrandViewModel()
        {
            Models = new HashSet<ModelViewModel>();
        }
        [Required(ErrorMessageResourceType = typeof(UI), ErrorMessageResourceName = nameof(UI.CannotBeEmpty))]
        public string Name { get; set; }

        [Required(ErrorMessageResourceType = typeof(UI), ErrorMessageResourceName = nameof(UI.CannotBeEmpty))]
        public string Description { get; set; }

        public ICollection<ModelViewModel> Models { get; set; }
    } 
}
