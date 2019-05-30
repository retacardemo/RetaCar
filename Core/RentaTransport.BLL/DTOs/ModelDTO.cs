using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentaTransport.BLL.DTOs
{
    public class ModelDTO: BaseDTO
    {
        public Guid BrandId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey(nameof(BrandId))]
        public BrandDTO Brand { get; set; }

    }
}
