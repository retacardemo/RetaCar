using System;
using static RentaTransport.Common.Constants.Enums;

namespace RentaTransport.AdminUI.Models
{
    public abstract class BaseViewModel
    {
        protected BaseViewModel()
        {
            Status = Status.Active;
        }

        public Guid Id { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
