using System;
using System.Collections.Generic;

namespace SSRNMFSSN.Data.Models
{
    public partial class Fleet
    {
        public Fleet()
        {
            DistributionContacts = new HashSet<DistributionContacts>();
            NiprNetReportNotification = new HashSet<NiprNetReportNotification>();
            Ship = new HashSet<Ship>();
            UnclassifiedTemplateForDistribution = new HashSet<UnclassifiedTemplateForDistribution>();
        }

        public int FleetId { get; set; }
        public string Fleet1 { get; set; }
        public string FleetName { get; set; }

        public virtual ICollection<DistributionContacts> DistributionContacts { get; set; }
        public virtual ICollection<NiprNetReportNotification> NiprNetReportNotification { get; set; }
        public virtual ICollection<Ship> Ship { get; set; }
        public virtual ICollection<UnclassifiedTemplateForDistribution> UnclassifiedTemplateForDistribution { get; set; }
    }
}
