using System;
using System.Collections.Generic;

namespace SSRNMFSSN.Data.Models
{
    public partial class TrialStatusDescription
    {
        public TrialStatusDescription()
        {
            SsrnmTrial = new HashSet<SsrnmTrial>();
        }

        public int TrialStatusDescriptionId { get; set; }
        public string TrialStatusDescription1 { get; set; }

        public virtual ICollection<SsrnmTrial> SsrnmTrial { get; set; }
    }
}
