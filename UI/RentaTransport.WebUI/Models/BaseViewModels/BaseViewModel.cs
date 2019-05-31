using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static RentaTransport.Common.Constants.Enums;

namespace RentaTransport.WebUI.Models
{
    public abstract class BaseViewModel
    {
        protected BaseViewModel()
        {
            Status = Status.Pending;
            CreatedDate = DateTime.UtcNow.AddHours(4);
            ModifiedDate = DateTime.UtcNow.AddHours(4);
        }

        public Guid Id { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
