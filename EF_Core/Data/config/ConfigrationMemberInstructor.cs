using EF_Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Core.Data.config
{
    public class ConfigrationMemberInstructor : IEntityTypeConfiguration<MemberInstructor>
    {
        public void Configure(EntityTypeBuilder<MemberInstructor> builder)
        {
            builder.HasKey(x => x.MemberInstructorID);
            builder.Property(x => x.MemberInstructorID).ValueGeneratedNever();

           builder.HasData(LoadMemberInstructors());
            builder.ToTable("MemberInstructors");
        }
        public static List<MemberInstructor> LoadMemberInstructors()
        {
            return new List<MemberInstructor>
            {
                new MemberInstructor{MemberInstructorID=1,MemberID=3,InstructorID=6,AssignDate=Convert.ToDateTime("2024-05-06")},
                new MemberInstructor{MemberInstructorID=7,MemberID=3,InstructorID=9,AssignDate=Convert.ToDateTime("2024-06-09")},
                new MemberInstructor{MemberInstructorID=8,MemberID=33,InstructorID=34,AssignDate=Convert.ToDateTime("2024-06-10")},
                new MemberInstructor{MemberInstructorID=9,MemberID=21,InstructorID=7,AssignDate=Convert.ToDateTime("2024-06-09")},
                new MemberInstructor{MemberInstructorID=10,MemberID=33,InstructorID=7,AssignDate=Convert.ToDateTime("2024-06-09")},
                new MemberInstructor{MemberInstructorID=11,MemberID=3,InstructorID=7,AssignDate=Convert.ToDateTime("2024-06-06")},
                new MemberInstructor{MemberInstructorID=12,MemberID=39,InstructorID=41,AssignDate=Convert.ToDateTime("2024-06-12")},
                new MemberInstructor{MemberInstructorID=13,MemberID=39,InstructorID=40,AssignDate=Convert.ToDateTime("2024-06-12")},
                new MemberInstructor{MemberInstructorID=14,MemberID=38,InstructorID=40,AssignDate=Convert.ToDateTime("2024-06-12")},
                new MemberInstructor{MemberInstructorID=15,MemberID=38,InstructorID=34,AssignDate=Convert.ToDateTime("2024-05-12")},
                new MemberInstructor{MemberInstructorID=16,MemberID=36,InstructorID=40,AssignDate=Convert.ToDateTime("2024-05-12")},
                new MemberInstructor{MemberInstructorID=18,MemberID=38,InstructorID=41,AssignDate=Convert.ToDateTime("2024-05-12")}


        };
        }

    }
}
