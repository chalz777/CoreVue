using System;
using System.Collections.Generic;

namespace SSRNMFSSN.Data.Models
{
    public partial class DataFrom
    {
        public DataFrom()
        {
            FssnTrial = new HashSet<FssnTrial>();
        }

        public int DataFromId { get; set; }
        public string DataFrom1 { get; set; }

        public virtual ICollection<FssnTrial> FssnTrial { get; set; }
    }
}
