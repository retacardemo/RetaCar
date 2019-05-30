using System.Collections.Generic;

namespace RentaTransport.BLL.DTOs
{
    public class BrandDTO: BaseDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<ModelDTO> Models { get; set; }
    }
}
