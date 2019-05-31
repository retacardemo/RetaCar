using Microsoft.AspNetCore.Identity;
using System;

namespace RentaTransport.BLL.DTOs
{
    public class UserClaimDto : IdentityUserClaim<Guid>
    {
    }
}
