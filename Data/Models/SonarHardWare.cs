using System;
using System.Collections.Generic;

namespace SSRNMFSSN.Data.Models
{
    public partial class SonarHardWare
    {
        public SonarHardWare()
        {
            Ship = new HashSet<Ship>();
        }

        public int SonarHardWareId { get; set; }
        public string SonarHardWare1 { get; set; }

        public virtual ICollection<Ship> Ship { get; set; }
    }
}
