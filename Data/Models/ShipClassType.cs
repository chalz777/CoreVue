using System;
using System.Collections.Generic;

namespace SSRNMFSSN.Data.Models
{
    public partial class ShipClassType
    {
        public ShipClassType()
        {
            ShipClass = new HashSet<ShipClass>();
        }

        public int ShipClassTypeId { get; set; }
        public string ShipClassType1 { get; set; }

        public virtual ICollection<ShipClass> ShipClass { get; set; }
    }
}
