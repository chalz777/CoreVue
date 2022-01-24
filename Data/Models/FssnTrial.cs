using System;
using System.Collections.Generic;

namespace SSRNMFSSN.Data.Models
{
    public partial class FssnTrial
    {
        public int TrialId { get; set; }
        public int ShipId { get; set; }
        public int? EnteredByUserId { get; set; }
        public int? DataFromId { get; set; }
        public DateTime DataDate { get; set; }
        public DateTime? DateReceived { get; set; }
        public DateTime? DateModified { get; set; }
        public int? DataStatusId { get; set; }
        public int? DataTypeId { get; set; }
        public string Cmsg { get; set; }
        public string CmsgPdf { get; set; }
        public string Umsg { get; set; }
        public string UmsgPdf { get; set; }
        public string Fmsg { get; set; }
        public string Analysis { get; set; }
        public string Review { get; set; }
        public string ReportPdf { get; set; }
        public int? ReportAccess { get; set; }
        public string Cpc { get; set; }
        public DateTime? PdfPosted { get; set; }
        public string DataFrom { get; set; }
        public DateTime? DateRecorded { get; set; }

        public virtual DataFrom DataFromNavigation { get; set; }
        public virtual DataStatus DataStatus { get; set; }
        public virtual DataType DataType { get; set; }
        public virtual User EnteredByUser { get; set; }
        public virtual Ship Ship { get; set; }
    }
}
