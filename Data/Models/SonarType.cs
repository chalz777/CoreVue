using System;
using System.Collections.Generic;

namespace SSRNMFSSN.Data.Models
{
    public partial class SonarType
    {
        public SonarType()
        {
            Ship = new HashSet<Ship>();
        }

        public int SonarTypeId { get; set; }
        public string SonarType1 { get; set; }

        public virtual ICollection<Ship> Ship { get; set; }
    }
}
