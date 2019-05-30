using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RentaTransport.DAL.DAOs
{
    [Table("Brands")]
    public class BrandDAO: BaseDAO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<ModelDAO> Models { get; set; }
    }
}
