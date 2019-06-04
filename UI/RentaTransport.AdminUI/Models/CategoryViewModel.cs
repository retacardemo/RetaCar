using RentaTransport.Common.Resources;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentaTransport.AdminUI.Models
{
    public class CategoryViewModel:BaseViewModel
    {
        public CategoryViewModel()
        {
            Cars = new HashSet<CarViewModel>();
        }

        [Required(ErrorMessageResourceType = typeof(UI), ErrorMessageResourceName = nameof(UI.CannotBeEmpty))]
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<CarViewModel> Cars { get; set; }
    }
}
