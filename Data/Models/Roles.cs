using System;
using System.Collections.Generic;

namespace SSRNMFSSN.Data.Models
{
    public partial class Roles
    {
        public Roles()
        {
            Users = new HashSet<User>();
        }

        public int RoleId { get; set; }
        public string Role { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
