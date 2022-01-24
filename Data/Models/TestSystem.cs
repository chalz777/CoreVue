using System;
using System.Collections.Generic;

namespace SSRNMFSSN.Data.Models
{
    public partial class TestSystem
    {
        public TestSystem()
        {
            SsrnmTrial = new HashSet<SsrnmTrial>();
        }

        public int TestSystemId { get; set; }
        public string TestSystem1 { get; set; }

        public virtual ICollection<SsrnmTrial> SsrnmTrial { get; set; }
    }
}
