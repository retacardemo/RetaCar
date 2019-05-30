using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentaTransport.WebUI.Models;

namespace RentaTransport.WebUI.ViewModels
{
    public class CommonViewModel
    {
        public IEnumerable<CarViewModel> Slides { get; set; }
    }
}
