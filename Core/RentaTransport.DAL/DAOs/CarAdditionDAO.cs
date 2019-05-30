using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RentaTransport.DAL.DAOs
{
    [Table("CarAdditions")]
    public class CarAdditionDAO : BaseDAO
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
