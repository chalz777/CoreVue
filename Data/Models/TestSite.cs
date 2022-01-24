using System;
using System.Collections.Generic;

namespace SSRNMFSSN.Data.Models
{
    public partial class TestSite
    {
        public TestSite()
        {
            SsrnmTrial = new HashSet<SsrnmTrial>();
        }

        public int TestSiteId { get; set; }
        public string TestSite1 { get; set; }

        public virtual ICollection<SsrnmTrial> SsrnmTrial { get; set; }
    }
}
