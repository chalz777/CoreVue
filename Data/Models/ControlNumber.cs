using System;
using System.Collections.Generic;

namespace SSRNMFSSN.Data.Models
{
    public partial class ControlNumber
    {
        public ControlNumber()
        {
            SsrnmTrial = new HashSet<SsrnmTrial>();
        }

        public int ControlNumberId { get; set; }
        public string ControlNumber1 { get; set; }

        public virtual ICollection<SsrnmTrial> SsrnmTrial { get; set; }
    }
}
