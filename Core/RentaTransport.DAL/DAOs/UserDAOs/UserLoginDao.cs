using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaTransport.DAL.DAOs
{
   public class UserLoginDao:IdentityUserLogin<Guid>
    {
    }
}
