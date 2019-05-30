using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RentaTransport.DAL.DAOs
{
    [Table("Models")]
    public class ModelDAO: BaseDAO
    {
        public Guid BrandId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey(nameof(BrandId))]
        public BrandDAO Brand { get; set; }
    }
}
