using System;

namespace RentaTransport.BLL.DTOs
{
    public class CustomerPhoneNumberDTO: BaseDTO
    {
        public Guid UserId { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public UserDto User { get; set; }

    }
}
