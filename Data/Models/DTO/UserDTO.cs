using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSRNMFSSN.Data.Models.DTO
{
    public class UserDto : EFModel, IDto
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public int RoleId { get; set; }
        public string Edipi { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public bool SsrnmAccess { get; set; }
        public bool FssnAccess { get; set; }
        public string SipreEmail { get; set; }
        public int UserStatusId { get; set; }

    }
}
