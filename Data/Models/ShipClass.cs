using System;
using System.Collections.Generic;

namespace SSRNMFSSN.Data.Models
{
    public partial class ShipClass
    {
        public ShipClass()
        {
            Ship = new HashSet<Ship>();
        }

        public int ShipClassId { get; set; }
        public string ShipClass1 { get; set; }
        public int ShipClassTypeId { get; set; }

        public virtual ShipClassType ShipClassType { get; set; }
        public virtual ICollection<Ship> Ship { get; set; }
    }
}
