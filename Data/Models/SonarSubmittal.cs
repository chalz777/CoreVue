using System;
using System.Collections.Generic;

namespace SSRNMFSSN.Data.Models
{
    public partial class SonarSubmittal
    {
        public SonarSubmittal()
        {
            Ship = new HashSet<Ship>();
        }

        public int SonarSubmittalId { get; set; }
        public string SonarSubmittal1 { get; set; }

        public virtual ICollection<Ship> Ship { get; set; }
    }
}
