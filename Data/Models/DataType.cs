using System;
using System.Collections.Generic;

namespace SSRNMFSSN.Data.Models
{
    public partial class DataType
    {
        public DataType()
        {
            FssnTrial = new HashSet<FssnTrial>();
        }

        public int DataTypeId { get; set; }
        public string DataType1 { get; set; }

        public virtual ICollection<FssnTrial> FssnTrial { get; set; }
    }
}
