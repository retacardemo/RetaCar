using Microsoft.AspNetCore.Identity;
using System;

namespace RentaTransport.BLL.DTOs
{
    public class RoleDto:IdentityRole<Guid>
    {
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
