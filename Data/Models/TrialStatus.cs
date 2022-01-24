using System;
using System.Collections.Generic;

namespace SSRNMFSSN.Data.Models
{
    public partial class TrialStatus
    {
        public TrialStatus()
        {
            SsrnmTrial = new HashSet<SsrnmTrial>();
        }

        public int TrialStatusId { get; set; }
        public string TrialStatus1 { get; set; }

        public virtual ICollection<SsrnmTrial> SsrnmTrial { get; set; }
    }
}
