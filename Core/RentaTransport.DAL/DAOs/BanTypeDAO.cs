using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RentaTransport.DAL.DAOs
{
    [Table("BanTypes")]
    public class BanTypeDAO: BaseDAO
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
