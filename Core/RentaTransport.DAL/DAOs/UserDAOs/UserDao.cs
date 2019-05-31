using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaTransport.DAL.DAOs
{
   public class UserDao:IdentityUser<Guid>
    {
        public UserDao()
        {
            PhoneNumbers = new HashSet<CustomerPhoneNumberDAO>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<CustomerPhoneNumberDAO> PhoneNumbers { get; set; }
    }
}
