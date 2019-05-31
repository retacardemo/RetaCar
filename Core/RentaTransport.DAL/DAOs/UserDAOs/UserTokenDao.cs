using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentaTransport.DAL.DAOs
{
    [Table("UserTokens")]
    public class UserTokenDao : IdentityUserToken<Guid>
    {
    }
}
