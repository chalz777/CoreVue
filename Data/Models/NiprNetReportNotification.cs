using System;
using System.Collections.Generic;

namespace SSRNMFSSN.Data.Models
{
    public partial class NiprNetReportNotification
    {
        public int NotificationId { get; set; }
        public string To { get; set; }
        public string Cc { get; set; }
        public int? FleetId { get; set; }

        public virtual Fleet Fleet { get; set; }
    }
}
