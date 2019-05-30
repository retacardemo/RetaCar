using System;
using System.Collections.Generic;
using System.Text;

namespace RentaTransport.Common.Constants
{
   public class Enums
    {
        public enum Status: byte
        {
            Active = 0,
            Deactive = 1,
            Deleted = 2,
            Pending = 3,
            Rejected = 4,
            Blocked = 5,
            None = 6
        }

        public enum CarGear : byte
        {
            
        }

        public enum Transmission : byte
        {
            Automatic = 0,
            Manual = 1
        }

        public enum AnnouncementStatus : byte
        {
            New = 0,
            Old = 1
        }
    }
}
