using System;
using System.Collections.Generic;

namespace SSRNMFSSN.Data.Models
{
    public partial class SsrnmTrial
    {
        public int TrialId { get; set; }
        public int ShipId { get; set; }
        public int? EnteredByUserId { get; set; }
        public DateTime TrialDate { get; set; }
        public DateTime? DateReceived { get; set; }
        public int? TestSiteId { get; set; }
        public int? TestSystemId { get; set; }
        public int? TrialStatusId { get; set; }
        public int? TrialTypeId { get; set; }
        public int? ControlNumberId { get; set; }
        public int? TrialStatusDescriptionId { get; set; }
        public string Cmsg { get; set; }
        public string CmsgPdf { get; set; }
        public string Umsg { get; set; }
        public string UmsgPdf { get; set; }
        public string Comments { get; set; }
        public string SchComments { get; set; }
        public string Notes { get; set; }
        public string Pages { get; set; }
        public string ReportMsg { get; set; }
        public string Cresults { get; set; }
        public string AmResults { get; set; }
        public string ReportFeedback { get; set; }
        public string ReportAudio { get; set; }
        public DateTime? ReportPstDte { get; set; }
        public string ReportPstCmt { get; set; }
        public string ReportPdf { get; set; }
        public string ReportXml { get; set; }
        public DateTime? AswCert { get; set; }

        public virtual ControlNumber ControlNumber { get; set; }
        public virtual User EnteredByUser { get; set; }
        public virtual Ship Ship { get; set; }
        public virtual TestSite TestSite { get; set; }
        public virtual TestSystem TestSystem { get; set; }
        public virtual TrialStatus TrialStatus { get; set; }
        public virtual TrialStatusDescription TrialStatusDescription { get; set; }
        public virtual TrialType TrialType { get; set; }
    }
}
