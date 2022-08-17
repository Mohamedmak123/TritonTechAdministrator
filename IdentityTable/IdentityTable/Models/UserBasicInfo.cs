using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityTable.Models
{
    public class UserBasicInfo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Guid RoleId { get; set; }
        public string Gender { get; set; }
        public string MobileNumber { get; set; }
        public Guid ReportingHeaderId { get; set; }
        public int Age { get; set; }
        public string BloodGroup { get; set; }
        public string Address { get; set; }
        public DateTime DateOfJoining { get; set; }
        public DateTime DateOfExit { get; set; }
    }
}
