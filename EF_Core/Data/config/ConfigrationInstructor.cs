using EF_Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Core.Data.config
{
    public class ConfigrationInstructor : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.Property(x => x.Qualification).HasColumnType("VARCHAR").HasMaxLength(100).IsRequired(false);
            builder.HasMany(x => x.Members).WithMany(x => x.Instructors).UsingEntity<MemberInstructor>();
            builder.HasData(LoadInstructors());
            builder.ToTable("Instructors");
        }
        public static List<Instructor> LoadInstructors()
        {
            return new List<Instructor>
            {
                new Instructor{PersonID=6,Name="Saleh", Address="1Street",Phone="77829388",Email=null,DateOfBirth=Convert.ToDateTime("2005-03-01"),Gender=1,Qualification="Belt"},
                new Instructor{PersonID=7,Name="Salwa",  Address="1Street",Phone="77829388",Email=null,DateOfBirth=Convert.ToDateTime("2005-06-01"),Gender=2,Qualification="Belt"},
                new Instructor{PersonID=9,Name="Mohammed",  Address="1Street",Phone="77829388",Email=null,DateOfBirth=Convert.ToDateTime("2005-06-01"),Gender=1,Qualification="Win Teakwindo"},
                new Instructor{PersonID=34,Name="Faisle", Address="1Street",Phone="77829388",Email=null,DateOfBirth=Convert.ToDateTime("2005-06-01"),Gender=1,Qualification="Belt Champions"},
                new Instructor{PersonID=40,Name="Faozy",Address="1Street",Phone="77829388",Email=null,DateOfBirth=Convert.ToDateTime("2005-06-01"),Gender=1,Qualification="Belt Win"},
                new Instructor{PersonID=41,Name="Rima Waled", Address="1Street",Phone="77829388",Email=null,DateOfBirth=Convert.ToDateTime("2005-06-01"),Gender=0,Qualification=null}

        };
        }

    }
}
