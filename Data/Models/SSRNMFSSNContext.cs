using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SSRNMFSSN.Data.Models
{
    public partial class SSRNMFSSNContext : DbContext
    {
        public SSRNMFSSNContext()
        {
        }

        public SSRNMFSSNContext(DbContextOptions<SSRNMFSSNContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Application> Application { get; set; }
        public virtual DbSet<ControlNumber> ControlNumber { get; set; }
        public virtual DbSet<DataFrom> DataFrom { get; set; }
        public virtual DbSet<DataStatus> DataStatus { get; set; }
        public virtual DbSet<DataType> DataType { get; set; }
        public virtual DbSet<DistributionContacts> DistributionContacts { get; set; }
        public virtual DbSet<Fleet> Fleet { get; set; }
        public virtual DbSet<FssnTrial> FssnTrial { get; set; }
        public virtual DbSet<MdataResult> MdataResult { get; set; }
        public virtual DbSet<NiprNetReportNotification> NiprNetReportNotification { get; set; }
        public virtual DbSet<PdataResult> PdataResult { get; set; }
        public virtual DbSet<Pmoprocedure> Pmoprocedure { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Ship> Ship { get; set; }
        public virtual DbSet<ShipClass> ShipClass { get; set; }
        public virtual DbSet<ShipClassType> ShipClassType { get; set; }
        public virtual DbSet<ShipStatus> ShipStatus { get; set; }
        public virtual DbSet<SonarAcquisition> SonarAcquisition { get; set; }
        public virtual DbSet<SonarHardWare> SonarHardWare { get; set; }
        public virtual DbSet<SonarSoftWare> SonarSoftWare { get; set; }
        public virtual DbSet<SonarSubmittal> SonarSubmittal { get; set; }
        public virtual DbSet<SonarType> SonarType { get; set; }
        public virtual DbSet<SsrnmTrial> SsrnmTrial { get; set; }
        public virtual DbSet<TestSite> TestSite { get; set; }
        public virtual DbSet<TestSystem> TestSystem { get; set; }
        public virtual DbSet<TrialStatus> TrialStatus { get; set; }
        public virtual DbSet<TrialStatusDescription> TrialStatusDescription { get; set; }
        public virtual DbSet<TrialType> TrialType { get; set; }
        public virtual DbSet<UnclassifiedTemplateForDistribution> UnclassifiedTemplateForDistribution { get; set; }
        public virtual DbSet<UserStatus> UserStatus { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Viewed> Viewed { get; set; }

        // Unable to generate entity type for table 'dbo.Ccr3Masker'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Ccr3Prairie'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=vcorpdevsql\\corpdev;Database=SSRNM-FSSN;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Application>(entity =>
            {
                entity.ToTable("Application", "dbo");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.Application1)
                    .IsRequired()
                    .HasColumnName("Application")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ControlNumber>(entity =>
            {
                entity.ToTable("ControlNumber", "dbo");

                entity.Property(e => e.ControlNumberId).HasColumnName("ControlNumberID");

                entity.Property(e => e.ControlNumber1)
                    .IsRequired()
                    .HasColumnName("ControlNumber")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataFrom>(entity =>
            {
                entity.ToTable("DataFrom", "dbo");

                entity.Property(e => e.DataFromId).HasColumnName("DataFromID");

                entity.Property(e => e.DataFrom1)
                    .IsRequired()
                    .HasColumnName("DataFrom")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataStatus>(entity =>
            {
                entity.ToTable("DataStatus", "dbo");

                entity.Property(e => e.DataStatusId).HasColumnName("DataStatusID");

                entity.Property(e => e.DataStatus1)
                    .IsRequired()
                    .HasColumnName("DataStatus")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataType>(entity =>
            {
                entity.ToTable("DataType", "dbo");

                entity.Property(e => e.DataTypeId).HasColumnName("DataTypeID");

                entity.Property(e => e.DataType1)
                    .IsRequired()
                    .HasColumnName("DataType")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DistributionContacts>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PK__Name");

                entity.ToTable("DistributionContacts", "dbo");

                entity.Property(e => e.Name)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FleetId).HasColumnName("FleetID");

                entity.HasOne(d => d.Fleet)
                    .WithMany(p => p.DistributionContacts)
                    .HasForeignKey(d => d.FleetId)
                    .HasConstraintName("FK__DistributionContacts__Fleet");
            });

            modelBuilder.Entity<Fleet>(entity =>
            {
                entity.ToTable("Fleet", "dbo");

                entity.Property(e => e.FleetId).HasColumnName("FleetID");

                entity.Property(e => e.Fleet1)
                    .IsRequired()
                    .HasColumnName("Fleet")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FleetName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FssnTrial>(entity =>
            {
                entity.HasKey(e => e.TrialId)
                    .HasName("PK__FssnTrial");

                entity.ToTable("FssnTrial", "dbo");

                entity.Property(e => e.TrialId).HasColumnName("TrialID");

                entity.Property(e => e.Cmsg)
                    .HasColumnName("CMsg")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CmsgPdf)
                    .HasColumnName("CMsgPdf")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cpc)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DataDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DataFrom)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DataFromId).HasColumnName("DataFromID");

                entity.Property(e => e.DataStatusId).HasColumnName("DataStatusID");

                entity.Property(e => e.DataTypeId).HasColumnName("DataTypeID");

                entity.Property(e => e.DateModified).HasColumnType("smalldatetime");

                entity.Property(e => e.DateReceived).HasColumnType("smalldatetime");

                entity.Property(e => e.DateRecorded).HasColumnType("smalldatetime");

                entity.Property(e => e.EnteredByUserId).HasColumnName("EnteredByUserID");

                entity.Property(e => e.Fmsg)
                    .HasColumnName("FMsg")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PdfPosted).HasColumnType("smalldatetime");

                entity.Property(e => e.ReportPdf)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipId).HasColumnName("ShipID");

                entity.Property(e => e.Umsg)
                    .HasColumnName("UMsg")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UmsgPdf)
                    .HasColumnName("UMsgPdf")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.DataFromNavigation)
                    .WithMany(p => p.FssnTrial)
                    .HasForeignKey(d => d.DataFromId)
                    .HasConstraintName("FK__FssnTrial__DataFrom");

                entity.HasOne(d => d.DataStatus)
                    .WithMany(p => p.FssnTrial)
                    .HasForeignKey(d => d.DataStatusId)
                    .HasConstraintName("FK__FssnTrial__DataStatus");

                entity.HasOne(d => d.DataType)
                    .WithMany(p => p.FssnTrial)
                    .HasForeignKey(d => d.DataTypeId)
                    .HasConstraintName("FK__FssnTrial__DataType");

                entity.HasOne(d => d.EnteredByUser)
                    .WithMany(p => p.FssnTrial)
                    .HasForeignKey(d => d.EnteredByUserId)
                    .HasConstraintName("FK__FssnTrial__User");

                entity.HasOne(d => d.Ship)
                    .WithMany(p => p.FssnTrial)
                    .HasForeignKey(d => d.ShipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FssnTrial__Ship");
            });

            modelBuilder.Entity<MdataResult>(entity =>
            {
                entity.ToTable("MDataResult", "dbo");

                entity.Property(e => e.MdataResultId).HasColumnName("MDataResultID");

                entity.Property(e => e.MdataResult1)
                    .IsRequired()
                    .HasColumnName("MDataResult")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NiprNetReportNotification>(entity =>
            {
                entity.HasKey(e => e.NotificationId)
                    .HasName("PK__NotificationID");

                entity.ToTable("NiprNetReportNotification", "dbo");

                entity.Property(e => e.NotificationId).HasColumnName("NotificationID");

                entity.Property(e => e.Cc)
                    .HasColumnName("CC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FleetId).HasColumnName("FleetID");

                entity.Property(e => e.To)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Fleet)
                    .WithMany(p => p.NiprNetReportNotification)
                    .HasForeignKey(d => d.FleetId)
                    .HasConstraintName("FK__NiprNetReportNotification__Fleet");
            });

            modelBuilder.Entity<PdataResult>(entity =>
            {
                entity.ToTable("PDataResult", "dbo");

                entity.Property(e => e.PdataResultId).HasColumnName("PDataResultID");

                entity.Property(e => e.PdataResult1)
                    .IsRequired()
                    .HasColumnName("PDataResult")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pmoprocedure>(entity =>
            {
                entity.ToTable("PMOProcedure", "dbo");

                entity.Property(e => e.PmoprocedureId).HasColumnName("PMOProcedureID");

                entity.Property(e => e.Pmoprocedure1)
                    .IsRequired()
                    .HasColumnName("PMOProcedure")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__Role");

                entity.ToTable("Roles", "dbo");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ship>(entity =>
            {
                entity.ToTable("Ship", "dbo");

                entity.Property(e => e.ShipId).HasColumnName("ShipID");

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.DecommisionDate).HasColumnType("datetime");

                entity.Property(e => e.FleetId).HasColumnName("FleetID");

                entity.Property(e => e.HullDesignation)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PmoprocedureId).HasColumnName("PMOProcedureID");

                entity.Property(e => e.ShipClassId).HasColumnName("ShipClassID");

                entity.Property(e => e.ShipName)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ShipStatusId).HasColumnName("ShipStatusID");

                entity.Property(e => e.SonarAcquisitionId).HasColumnName("SonarAcquisitionID");

                entity.Property(e => e.SonarHardwareId).HasColumnName("SonarHardwareID");

                entity.Property(e => e.SonarSoftwareId).HasColumnName("SonarSoftwareID");

                entity.Property(e => e.SonarSubmittalId).HasColumnName("SonarSubmittalID");

                entity.Property(e => e.SonarTypeId).HasColumnName("SonarTypeID");

                entity.HasOne(d => d.Fleet)
                    .WithMany(p => p.Ship)
                    .HasForeignKey(d => d.FleetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ship__Fleet");

                entity.HasOne(d => d.Pmoprocedure)
                    .WithMany(p => p.Ship)
                    .HasForeignKey(d => d.PmoprocedureId)
                    .HasConstraintName("FK__Ship__PMOProcedure");

                entity.HasOne(d => d.ShipClass)
                    .WithMany(p => p.Ship)
                    .HasForeignKey(d => d.ShipClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ship__ShipClass");

                entity.HasOne(d => d.ShipStatus)
                    .WithMany(p => p.Ship)
                    .HasForeignKey(d => d.ShipStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ship__ShipStatus");

                entity.HasOne(d => d.SonarAcquisition)
                    .WithMany(p => p.Ship)
                    .HasForeignKey(d => d.SonarAcquisitionId)
                    .HasConstraintName("FK__Ship__SonarAcquisition");

                entity.HasOne(d => d.SonarHardware)
                    .WithMany(p => p.Ship)
                    .HasForeignKey(d => d.SonarHardwareId)
                    .HasConstraintName("FK__Ship__SonarHardware");

                entity.HasOne(d => d.SonarSoftware)
                    .WithMany(p => p.Ship)
                    .HasForeignKey(d => d.SonarSoftwareId)
                    .HasConstraintName("FK__Ship__SonarSoftware");

                entity.HasOne(d => d.SonarSubmittal)
                    .WithMany(p => p.Ship)
                    .HasForeignKey(d => d.SonarSubmittalId)
                    .HasConstraintName("FK__Ship__SonarSubmittal");

                entity.HasOne(d => d.SonarType)
                    .WithMany(p => p.Ship)
                    .HasForeignKey(d => d.SonarTypeId)
                    .HasConstraintName("FK__Ship__SonarType");
            });

            modelBuilder.Entity<ShipClass>(entity =>
            {
                entity.ToTable("ShipClass", "dbo");

                entity.Property(e => e.ShipClassId).HasColumnName("ShipClassID");

                entity.Property(e => e.ShipClass1)
                    .IsRequired()
                    .HasColumnName("ShipClass")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipClassTypeId).HasColumnName("ShipClassTypeID");

                entity.HasOne(d => d.ShipClassType)
                    .WithMany(p => p.ShipClass)
                    .HasForeignKey(d => d.ShipClassTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ShipClass__ShipClassType");
            });

            modelBuilder.Entity<ShipClassType>(entity =>
            {
                entity.ToTable("ShipClassType", "dbo");

                entity.Property(e => e.ShipClassTypeId).HasColumnName("ShipClassTypeID");

                entity.Property(e => e.ShipClassType1)
                    .IsRequired()
                    .HasColumnName("ShipClassType")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShipStatus>(entity =>
            {
                entity.ToTable("ShipStatus", "dbo");

                entity.Property(e => e.ShipStatusId).HasColumnName("ShipStatusID");

                entity.Property(e => e.ShipStatus1)
                    .IsRequired()
                    .HasColumnName("ShipStatus")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SonarAcquisition>(entity =>
            {
                entity.ToTable("SonarAcquisition", "dbo");

                entity.Property(e => e.SonarAcquisitionId).HasColumnName("SonarAcquisitionID");

                entity.Property(e => e.SonarAcquisition1)
                    .IsRequired()
                    .HasColumnName("SonarAcquisition")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SonarHardWare>(entity =>
            {
                entity.ToTable("SonarHardWare", "dbo");

                entity.Property(e => e.SonarHardWareId).HasColumnName("SonarHardWareID");

                entity.Property(e => e.SonarHardWare1)
                    .IsRequired()
                    .HasColumnName("SonarHardWare")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SonarSoftWare>(entity =>
            {
                entity.ToTable("SonarSoftWare", "dbo");

                entity.Property(e => e.SonarSoftWareId).HasColumnName("SonarSoftWareID");

                entity.Property(e => e.SonarSoftWare1)
                    .IsRequired()
                    .HasColumnName("SonarSoftWare")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SonarSubmittal>(entity =>
            {
                entity.ToTable("SonarSubmittal", "dbo");

                entity.Property(e => e.SonarSubmittalId).HasColumnName("SonarSubmittalID");

                entity.Property(e => e.SonarSubmittal1)
                    .IsRequired()
                    .HasColumnName("SonarSubmittal")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SonarType>(entity =>
            {
                entity.ToTable("SonarType", "dbo");

                entity.Property(e => e.SonarTypeId).HasColumnName("SonarTypeID");

                entity.Property(e => e.SonarType1)
                    .IsRequired()
                    .HasColumnName("SonarType")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SsrnmTrial>(entity =>
            {
                entity.HasKey(e => e.TrialId)
                    .HasName("PK__SsrnmTrial");

                entity.ToTable("SsrnmTrial", "dbo");

                entity.Property(e => e.TrialId).HasColumnName("TrialID");

                entity.Property(e => e.AmResults)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AswCert).HasColumnType("smalldatetime");

                entity.Property(e => e.Cmsg)
                    .HasColumnName("CMsg")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CmsgPdf)
                    .HasColumnName("CMsgPdf")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.ControlNumberId).HasColumnName("ControlNumberID");

                entity.Property(e => e.Cresults)
                    .HasColumnName("CResults")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DateReceived).HasColumnType("smalldatetime");

                entity.Property(e => e.EnteredByUserId).HasColumnName("EnteredByUserID");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.Pages)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ReportAudio)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReportFeedback)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReportMsg).IsUnicode(false);

                entity.Property(e => e.ReportPdf)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportPstCmt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportPstDte).HasColumnType("smalldatetime");

                entity.Property(e => e.ReportXml)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SchComments).IsUnicode(false);

                entity.Property(e => e.ShipId).HasColumnName("ShipID");

                entity.Property(e => e.TestSiteId).HasColumnName("TestSiteID");

                entity.Property(e => e.TestSystemId).HasColumnName("TestSystemID");

                entity.Property(e => e.TrialDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TrialStatusDescriptionId).HasColumnName("TrialStatusDescriptionID");

                entity.Property(e => e.TrialStatusId).HasColumnName("TrialStatusID");

                entity.Property(e => e.TrialTypeId).HasColumnName("TrialTypeID");

                entity.Property(e => e.Umsg)
                    .HasColumnName("UMsg")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UmsgPdf)
                    .HasColumnName("UMsgPdf")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ControlNumber)
                    .WithMany(p => p.SsrnmTrial)
                    .HasForeignKey(d => d.ControlNumberId)
                    .HasConstraintName("FK__SsrnmTrial__ControlNumber");

                entity.HasOne(d => d.EnteredByUser)
                    .WithMany(p => p.SsrnmTrial)
                    .HasForeignKey(d => d.EnteredByUserId)
                    .HasConstraintName("FK__SsrnmTrial__User");

                entity.HasOne(d => d.Ship)
                    .WithMany(p => p.SsrnmTrial)
                    .HasForeignKey(d => d.ShipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SSRNMTrial__Ship");

                entity.HasOne(d => d.TestSite)
                    .WithMany(p => p.SsrnmTrial)
                    .HasForeignKey(d => d.TestSiteId)
                    .HasConstraintName("FK__SsrnmTrial__TestSite");

                entity.HasOne(d => d.TestSystem)
                    .WithMany(p => p.SsrnmTrial)
                    .HasForeignKey(d => d.TestSystemId)
                    .HasConstraintName("FK__SsrnmTrial__TestSystem");

                entity.HasOne(d => d.TrialStatusDescription)
                    .WithMany(p => p.SsrnmTrial)
                    .HasForeignKey(d => d.TrialStatusDescriptionId)
                    .HasConstraintName("FK__SsrnmTrial__TrialStatusDescription");

                entity.HasOne(d => d.TrialStatus)
                    .WithMany(p => p.SsrnmTrial)
                    .HasForeignKey(d => d.TrialStatusId)
                    .HasConstraintName("FK__SsrnmTrial__TrialStatus");

                entity.HasOne(d => d.TrialType)
                    .WithMany(p => p.SsrnmTrial)
                    .HasForeignKey(d => d.TrialTypeId)
                    .HasConstraintName("FK__SsrnmTrial__TrialType");
            });

            modelBuilder.Entity<TestSite>(entity =>
            {
                entity.ToTable("TestSite", "dbo");

                entity.Property(e => e.TestSiteId).HasColumnName("TestSiteID");

                entity.Property(e => e.TestSite1)
                    .IsRequired()
                    .HasColumnName("TestSite")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TestSystem>(entity =>
            {
                entity.ToTable("TestSystem", "dbo");

                entity.Property(e => e.TestSystemId).HasColumnName("TestSystemID");

                entity.Property(e => e.TestSystem1)
                    .HasColumnName("TestSystem")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrialStatus>(entity =>
            {
                entity.ToTable("TrialStatus", "dbo");

                entity.Property(e => e.TrialStatusId).HasColumnName("TrialStatusID");

                entity.Property(e => e.TrialStatus1)
                    .HasColumnName("TrialStatus")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrialStatusDescription>(entity =>
            {
                entity.ToTable("TrialStatusDescription", "dbo");

                entity.Property(e => e.TrialStatusDescriptionId).HasColumnName("TrialStatusDescriptionID");

                entity.Property(e => e.TrialStatusDescription1)
                    .IsRequired()
                    .HasColumnName("TrialStatusDescription")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrialType>(entity =>
            {
                entity.ToTable("TrialType", "dbo");

                entity.Property(e => e.TrialTypeId).HasColumnName("TrialTypeID");

                entity.Property(e => e.TrialType1)
                    .IsRequired()
                    .HasColumnName("TrialType")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnclassifiedTemplateForDistribution>(entity =>
            {
                entity.HasKey(e => e.DistId)
                    .HasName("PK__DistID");

                entity.ToTable("UnclassifiedTemplateForDistribution", "dbo");

                entity.Property(e => e.DistId).HasColumnName("DistID");

                entity.Property(e => e.AddForDdgsOnly)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FleetId).HasColumnName("FleetID");

                entity.Property(e => e.Info)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.To)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Fleet)
                    .WithMany(p => p.UnclassifiedTemplateForDistribution)
                    .HasForeignKey(d => d.FleetId)
                    .HasConstraintName("FK__UnclassifiedTemplateForDistribution__Fleet");
            });

            modelBuilder.Entity<UserStatus>(entity =>
            {
                entity.ToTable("UserStatus", "dbo");

                entity.Property(e => e.UserStatusId).HasColumnName("UserStatusID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__User");

                entity.ToTable("Users", "dbo");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Edipi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleInitial)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.SipreEmail)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.UserStatusId).HasColumnName("UserStatusID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Users__Roles");

                entity.HasOne(d => d.UserStatus)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Users__UserStatus");
            });

            modelBuilder.Entity<Viewed>(entity =>
            {
                entity.HasKey(e => e.ViewId)
                    .HasName("PK__Viewed");

                entity.ToTable("Viewed", "dbo");

                entity.Property(e => e.ViewId).HasColumnName("ViewID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.DateViewed).HasColumnType("smalldatetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.Viewed)
                    .HasForeignKey(d => d.ApplicationId)
                    .HasConstraintName("FK__Viewed__Application");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Viewed)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Viewed__Users");
            });
        }
    }
}
