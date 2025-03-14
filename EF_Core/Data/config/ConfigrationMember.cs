using EF_Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Core.Data.config
{
    public class ConfigrationMember : IEntityTypeConfiguration<Member>
    {

        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(x => x.EmergencyContactInfo).HasColumnType("VARCHAR").HasMaxLength(100).IsRequired();
            builder.HasOne(x=>x.BeltRank).WithMany(x=>x.Members).HasForeignKey(x=>x.LastBeltRankID).IsRequired();
            builder.HasMany(x => x.Payments).WithOne(x => x.Member).HasForeignKey(x => x.MemberID).IsRequired();
            builder.HasData(LoadMembers());
            builder.ToTable("Members");
        }
        public static List<Member> LoadMembers()
        {
            return new List<Member>
            {
                new Member {PersonID=3,Name="Ali Ahemd", Address="1Street",Phone="77829388",Email=null,DateOfBirth=Convert.ToDateTime("2004-05-11"),Gender=1,EmergencyContactInfo="343434",LastBeltRankID=4,IsActive=true},
                new Member { PersonID = 4, Name = " Ahmed", Address="1Street",Phone="77829388",Email=null, DateOfBirth = Convert.ToDateTime("2005-04-01"), Gender = 1,EmergencyContactInfo = "343434",LastBeltRankID=1,IsActive=false },
                new Member { PersonID=21,Name="Waled",Address="1Street",Phone="77829388",Email=null,DateOfBirth=Convert.ToDateTime("2005-06-01"),Gender=1,EmergencyContactInfo="343434",LastBeltRankID=3,IsActive=true },
                new Member { PersonID=33,Name="Fahed Ahmed",  Address="1Street",Phone="77829388",Email=null,DateOfBirth=Convert.ToDateTime("2005-06-01"),Gender=1,EmergencyContactInfo="343434",LastBeltRankID=5,IsActive=true },
                new Member { PersonID=36,Name="Omar Ali",Address="1Street",Phone="77829388",Email=null,DateOfBirth=Convert.ToDateTime("2005-06-01"),Gender=1,EmergencyContactInfo="343434",LastBeltRankID=1,IsActive=true },
                new Member { PersonID=37,Name="Mohand Faisle",  Address="1Street",Phone="77829388",Email=null,DateOfBirth=Convert.ToDateTime("2005-06-01"),Gender=1,EmergencyContactInfo="343434",LastBeltRankID=1,IsActive=true },
                new Member { PersonID=38,Name="Khaled Waled",Address="1Street",Phone="77829388",Email=null,DateOfBirth=Convert.ToDateTime("2005-06-01"),Gender=1,EmergencyContactInfo="343434",LastBeltRankID=10,IsActive=true },
                new Member { PersonID=39,Name="Zahrh Ahmed", Address="1Street",Phone="77829388",Email=null,DateOfBirth=Convert.ToDateTime("2005-06-01"),Gender=0,EmergencyContactInfo="343434",LastBeltRankID=4,IsActive=true }
        };
        }

    }
}
