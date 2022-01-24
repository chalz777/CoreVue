//using SSRNMFSSN.Data.Models;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace DataSourceConfigurations
//{
//    class UserConfiguration : IEntityTypeConfiguration<User>
//    {
//        public void Configure(EntityTypeBuilder<User> builder)
//        {
//            builder.ToTable("User", "dbo");

//            builder.HasKey(o => o.UserId);

//            builder.Property(e => e.UserId)
//                .UseSqlServerIdentityColumn()
//                .Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

//            builder.Property(e => e.Edipi)
//                    .HasMaxLength(25)
//                    .IsUnicode(false);

//            builder.Property(e => e.Email)
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//            builder.Property(e => e.FirstName)
//                    .HasColumnName("First_Name")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//            builder.Property(e => e.LastName)
//                    .HasColumnName("Last_Name")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//        }
//    }
//}