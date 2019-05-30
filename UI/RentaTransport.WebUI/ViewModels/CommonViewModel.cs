using System.Collections.Generic;
using RentaTransport.BLL.DTOs;
using RentaTransport.WebUI.Models;

namespace RentaTransport.WebUI.ViewModels
{
    public class CommonViewModel
    {
        public IEnumerable<CarDTO> Slides { get; set; }
    }
}
