using System;
using System.Collections.Generic;

namespace SSRNMFSSN.Data.Models
{
    public partial class Ship
    {
        public Ship()
        {
            FssnTrial = new HashSet<FssnTrial>();
            SsrnmTrial = new HashSet<SsrnmTrial>();
        }

        public int ShipId { get; set; }
        public string HullDesignation { get; set; }
        public string ShipName { get; set; }
        public int ShipClassId { get; set; }
        public int FleetId { get; set; }
        public int ShipStatusId { get; set; }
        public DateTime? DecommisionDate { get; set; }
        public int? SonarTypeId { get; set; }
        public int? SonarHardwareId { get; set; }
        public int? SonarSoftwareId { get; set; }
        public int? SonarAcquisitionId { get; set; }
        public int? SonarSubmittalId { get; set; }
        public int? PmoprocedureId { get; set; }
        public string Comments { get; set; }
        public int? HullSort { get; set; }

        public virtual Fleet Fleet { get; set; }
        public virtual Pmoprocedure Pmoprocedure { get; set; }
        public virtual ShipClass ShipClass { get; set; }
        public virtual ShipStatus ShipStatus { get; set; }
        public virtual SonarAcquisition SonarAcquisition { get; set; }
        public virtual SonarHardWare SonarHardware { get; set; }
        public virtual SonarSoftWare SonarSoftware { get; set; }
        public virtual SonarSubmittal SonarSubmittal { get; set; }
        public virtual SonarType SonarType { get; set; }
        public virtual ICollection<FssnTrial> FssnTrial { get; set; }
        public virtual ICollection<SsrnmTrial> SsrnmTrial { get; set; }
    }
}
