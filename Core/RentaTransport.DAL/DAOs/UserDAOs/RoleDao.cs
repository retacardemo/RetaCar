using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RentaTransport.DAL.DAOs
{   
      [Table("Roles")]
      public class RoleDao:IdentityRole<Guid>
      {
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
      }
}
