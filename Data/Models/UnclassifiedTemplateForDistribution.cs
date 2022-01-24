using System;
using System.Collections.Generic;

namespace SSRNMFSSN.Data.Models
{
    public partial class UnclassifiedTemplateForDistribution
    {
        public int DistId { get; set; }
        public string To { get; set; }
        public string Info { get; set; }
        public string AddForDdgsOnly { get; set; }
        public int? FleetId { get; set; }

        public virtual Fleet Fleet { get; set; }
    }
}
