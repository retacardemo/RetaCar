using System;

namespace RentaTransport.BLL.DTOs
{
    public class CarImageDTO: BaseDTO
    {
        public string Name { get; set; }
        public string MimeType { get; set; }
        public byte[] Photo { get; set; }
        public string Base64StringImage => string.Format("data:image/gif;base64,{0}", Convert.ToBase64String(Photo));
        public CarDTO Car { get; set; }
    }
}
