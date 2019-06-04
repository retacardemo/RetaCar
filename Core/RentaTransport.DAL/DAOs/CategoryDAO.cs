using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentaTransport.DAL.DAOs
{
    [Table("Categories")]
   public class CategoryDAO:BaseDAO
    {
        public CategoryDAO()
        {
            Cars = new HashSet<CarDAO>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<CarDAO> Cars { get; set; }
    }
}
