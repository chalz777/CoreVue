using System;
using System.Collections.Generic;

namespace SSRNMFSSN.Data.Models
{
    public partial class Viewed
    {
        public int ViewId { get; set; }
        public int? UserId { get; set; }
        public int? ApplicationId { get; set; }
        public DateTime? DateViewed { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }

        public virtual Application Application { get; set; }
        public virtual User User { get; set; }
    }
}
