using System;
using System.Collections.Generic;

namespace SSRNMFSSN.Data.Models
{
    public partial class SonarAcquisition
    {
        public SonarAcquisition()
        {
            Ship = new HashSet<Ship>();
        }

        public int SonarAcquisitionId { get; set; }
        public string SonarAcquisition1 { get; set; }

        public virtual ICollection<Ship> Ship { get; set; }
    }
}
