using System;
using System.Collections.Generic;

namespace SSRNMFSSN.Data.Models
{
    public partial class ShipStatus
    {
        public ShipStatus()
        {
            Ship = new HashSet<Ship>();
        }

        public int ShipStatusId { get; set; }
        public string ShipStatus1 { get; set; }

        public virtual ICollection<Ship> Ship { get; set; }
    }
}
