using System;
using System.Collections.Generic;

namespace SSRNMFSSN.Data.Models
{
    public partial class SonarSoftWare
    {
        public SonarSoftWare()
        {
            Ship = new HashSet<Ship>();
        }

        public int SonarSoftWareId { get; set; }
        public string SonarSoftWare1 { get; set; }

        public virtual ICollection<Ship> Ship { get; set; }
    }
}
