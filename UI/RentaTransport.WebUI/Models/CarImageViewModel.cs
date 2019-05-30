using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentaTransport.WebUI.Models.BaseViewModels;

namespace RentaTransport.WebUI.Models
{
    public class CarImageViewModel:BaseViewModel
    {
        public string Name { get; set; }
        public string MimeType { get; set; }
        public byte[] Photo { get; set; }
        public string Base64StringImage => string.Format("data:image/gif;base64,{0}", Convert.ToBase64String(Photo));
        public CarViewModel Car { get; set; }
    }
}
