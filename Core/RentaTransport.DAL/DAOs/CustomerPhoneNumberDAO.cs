using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RentaTransport.DAL.DAOs
{
    [Table("CustomerPhoneNumbers")]
    public class CustomerPhoneNumberDAO : BaseDAO
    {
        public Guid UserId { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }

        [ForeignKey(nameof(UserId))]
        public UserDao User { get; set; }

    }
}
