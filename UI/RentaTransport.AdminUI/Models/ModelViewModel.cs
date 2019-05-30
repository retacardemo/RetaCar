using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentaTransport.AdminUI.Models
{
    public class ModelViewModel:BaseViewModel
    {
        public Guid BrandId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public BrandViewModel Brand { get; set; }
    }
}
