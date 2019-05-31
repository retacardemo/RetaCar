﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RentaTransport.DAL.DAOs
{
    [Table("UserRoles")]
    public class UserRoleDao : IdentityUserRole<Guid>
    {
    }
}
