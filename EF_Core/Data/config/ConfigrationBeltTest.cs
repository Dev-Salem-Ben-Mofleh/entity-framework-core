using EF_Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Core.Data.config
{
    public class ConfigrationBeltTest : IEntityTypeConfiguration<BeltTest>
    {
        public void Configure(EntityTypeBuilder<BeltTest> builder)
        {
            builder.HasKey(x => x.BeltTestID);
            builder.Property(x => x.BeltTestID).ValueGeneratedNever();
            builder.HasOne(x => x.Member).WithMany(x => x.BeltTests).HasForeignKey(x => x.MemberID);
            builder.HasOne(x => x.BeltRank).WithMany(x => x.BeltTests).HasForeignKey(x => x.BeltRankID);
            builder.HasOne(x => x.Instructor).WithMany(x => x.BeltTests).HasForeignKey(x => x.InstructorID);
            builder.HasOne(x => x.Payment).WithOne(x => x.BeltTest).HasForeignKey<BeltTest>(x => x.PaymentID);

            builder.HasData(LoadBeltTests());

            builder.ToTable("BeltTests");
        }
        public static List<BeltTest> LoadBeltTests()
        {
            return new List<BeltTest>
            {
                new BeltTest{BeltTestID=2,MemberID=3,BeltRankID=1,Result=true,Date=Convert.ToDateTime("2024 - 06 - 11"),InstructorID=9,PaymentID=17},
                new BeltTest{BeltTestID=3,MemberID=3,BeltRankID=2,Result=false,Date=Convert.ToDateTime("2024 - 06 - 11"),InstructorID=9,PaymentID=18},
                new BeltTest{BeltTestID=4,MemberID=3,BeltRankID=2,Result=false,Date=Convert.ToDateTime(" 2024 - 06 - 11"),InstructorID=7,PaymentID=19},
                new BeltTest{BeltTestID=5,MemberID=3,BeltRankID=2,Result=true,Date=Convert.ToDateTime("2024 - 06 - 11"),InstructorID=7,PaymentID=20},
                new BeltTest{BeltTestID=6,MemberID=3,BeltRankID=6,Result=true,Date=Convert.ToDateTime(" 2024 - 06 - 11"),InstructorID=9,PaymentID=21},
                new BeltTest{BeltTestID=11,MemberID=38,BeltRankID=7,Result=true,Date=Convert.ToDateTime("2024 - 06 - 12 "),InstructorID=40,PaymentID=32},
                new BeltTest{BeltTestID=12,MemberID=38,BeltRankID=8,Result=true,Date=Convert.ToDateTime("2024 - 06 - 12"),InstructorID=41,PaymentID=33},
                new BeltTest{BeltTestID=13,MemberID=38,BeltRankID=9,Result=true,Date=Convert.ToDateTime("2024 - 06 - 12"),InstructorID=40,PaymentID=34},
                new BeltTest{BeltTestID=14,MemberID=39,BeltRankID=1,Result=false,Date=Convert.ToDateTime("2024 - 06 - 12  "),InstructorID=40,PaymentID=35},
                new BeltTest{BeltTestID=15,MemberID=39,BeltRankID=1,Result=true,Date=Convert.ToDateTime(" 2024 - 06 - 12"),InstructorID=41,PaymentID=36},
                new BeltTest{BeltTestID=16,MemberID=39,BeltRankID=2,Result=true,Date=Convert.ToDateTime("2024 - 06 - 13"),InstructorID=41,PaymentID=37},
                new BeltTest{BeltTestID=17,MemberID=39,BeltRankID=2,Result=true,Date=Convert.ToDateTime("2024 - 06 - 13"),InstructorID=40,PaymentID=38}



        };

        }
    }
}
