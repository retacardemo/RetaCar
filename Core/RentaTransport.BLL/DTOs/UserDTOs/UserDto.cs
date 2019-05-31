using Microsoft.AspNetCore.Identity;
using System;
using System.Collections;
using System.Collections.Generic;

namespace RentaTransport.BLL.DTOs
{
    public class UserDto:IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<CustomerPhoneNumberDTO> PhoneNumbers { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
