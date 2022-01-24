using System;
using System.Collections.Generic;

namespace SSRNMFSSN.Data.Models
{
    public partial class User
    {
        public User()
        {
            FssnTrial = new HashSet<FssnTrial>();
            SsrnmTrial = new HashSet<SsrnmTrial>();
            Viewed = new HashSet<Viewed>();
        }

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

        public virtual Roles Role { get; set; }
        public virtual UserStatus UserStatus { get; set; }
        public virtual ICollection<FssnTrial> FssnTrial { get; set; }
        public virtual ICollection<SsrnmTrial> SsrnmTrial { get; set; }
        public virtual ICollection<Viewed> Viewed { get; set; }
    }
}
