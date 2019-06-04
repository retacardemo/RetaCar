using System;
using System.Collections.Generic;
using System.Text;

namespace RentaTransport.BLL.DTOs
{
    public class CategoryDTO:BaseDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<CarDTO> Cars { get; set; }
    }
}
