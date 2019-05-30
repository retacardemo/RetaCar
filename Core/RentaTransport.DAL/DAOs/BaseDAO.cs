using System;
using System.Collections.Generic;
using System.Text;
using static RentaTransport.Common.Constants.Enums;

namespace RentaTransport.DAL.DAOs
{
    public abstract class BaseDAO
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? CreatedUserId { get; set; }
        public Guid? ModifiedUserId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Status Status { get; set; }
        public string StatusName => Status.ToString();
    }
}
