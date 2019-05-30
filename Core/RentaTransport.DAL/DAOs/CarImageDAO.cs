using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RentaTransport.DAL.DAOs
{
    [Table("CarImages")]
    public class CarImageDAO : BaseDAO
    {
        public Guid CarId { get; set; }
        public string Name { get; set; }
        public string MimeType { get; set; }
        public byte[] Photo { get; set; }

        [ForeignKey(nameof(CarId))]
        public CarDAO Car { get; set; }
    }
}
