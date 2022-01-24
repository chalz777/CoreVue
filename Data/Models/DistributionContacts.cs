using System;
using System.Collections.Generic;

namespace SSRNMFSSN.Data.Models
{
    public partial class DistributionContacts
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int? FleetId { get; set; }

        public virtual Fleet Fleet { get; set; }
    }
}
