using System;
using System.Collections.Generic;

namespace SSRNMFSSN.Data.Models
{
    public partial class Pmoprocedure
    {
        public Pmoprocedure()
        {
            Ship = new HashSet<Ship>();
        }

        public int PmoprocedureId { get; set; }
        public string Pmoprocedure1 { get; set; }

        public virtual ICollection<Ship> Ship { get; set; }
    }
}
