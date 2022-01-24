using System;
using System.Collections.Generic;

namespace SSRNMFSSN.Data.Models
{
    public partial class DataStatus
    {
        public DataStatus()
        {
            FssnTrial = new HashSet<FssnTrial>();
        }

        public int DataStatusId { get; set; }
        public string DataStatus1 { get; set; }

        public virtual ICollection<FssnTrial> FssnTrial { get; set; }
    }
}
