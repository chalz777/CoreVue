using System;
using System.Collections.Generic;

namespace SSRNMFSSN.Data.Models
{
    public partial class TrialType
    {
        public TrialType()
        {
            SsrnmTrial = new HashSet<SsrnmTrial>();
        }

        public int TrialTypeId { get; set; }
        public string TrialType1 { get; set; }

        public virtual ICollection<SsrnmTrial> SsrnmTrial { get; set; }
    }
}
