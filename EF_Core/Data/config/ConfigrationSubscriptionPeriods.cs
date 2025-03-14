using EF_Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Core.Data.config
{
    public class ConfigrationSubscriptionPeriods : IEntityTypeConfiguration<SubscriptionPeriod>
    {
        public void Configure(EntityTypeBuilder<SubscriptionPeriod> builder)
        {
          
            builder.HasKey(x => x.SubscriptionPeriodID);
            builder.Property(x => x.SubscriptionPeriodID).ValueGeneratedNever();
            builder.Property(x => x.Fees).HasPrecision(10, 2);
            builder.HasOne(x => x.Member).WithMany(x=>x.SubscriptionPeriods).HasForeignKey(x=>x.MemberID);
            builder.HasData(LoadSubscriptionPeriods());
            builder.ToTable("SubscriptionPeriod");

        }
        public static List<SubscriptionPeriod> LoadSubscriptionPeriods()
        {
            return new List<SubscriptionPeriod>
            {
                new SubscriptionPeriod{SubscriptionPeriodID=1,StartDate=Convert.ToDateTime("2024-06-05"),
                    EndDate=Convert.ToDateTime("2024-07-05"),Fees=50.0000M,Paid=true,MemberID=3,PaymentID=1,IssueReason=1,SubscrpitonDays=30,IsActive=false},
                new SubscriptionPeriod{SubscriptionPeriodID=9,StartDate=Convert.ToDateTime("2024-06-10"),
                    EndDate=Convert.ToDateTime("2024-07-19"),Fees=60.0000M,Paid=true,MemberID=21,PaymentID=6,IssueReason=1,SubscrpitonDays=38,IsActive=false},
                new SubscriptionPeriod{SubscriptionPeriodID=14,StartDate=Convert.ToDateTime("2024-06-10"),
                    EndDate=Convert.ToDateTime("2024-07-10"),Fees=70.0000M,Paid=true,MemberID=21,PaymentID=25,IssueReason=1,SubscrpitonDays=30,IsActive=false},
                new SubscriptionPeriod{SubscriptionPeriodID=19,StartDate=Convert.ToDateTime("2024-06-10"),
                    EndDate=Convert.ToDateTime("2024-07-10"),Fees=50.0000M,Paid=true,MemberID=3,PaymentID=14,IssueReason=1,SubscrpitonDays=30,IsActive=false},
                new SubscriptionPeriod{SubscriptionPeriodID=25,StartDate=Convert.ToDateTime("2024-06-12"),
                    EndDate=Convert.ToDateTime("2024-07-31"),Fees=200.0000M,Paid=true,MemberID=39,PaymentID=22,IssueReason=1,SubscrpitonDays=48,IsActive=false},
                new SubscriptionPeriod{SubscriptionPeriodID=26,StartDate=Convert.ToDateTime("2024-06-12"),
                    EndDate=Convert.ToDateTime("2024-07-12"),Fees=400.0000M,Paid=true,MemberID=38,PaymentID=23,IssueReason=1,SubscrpitonDays=30,IsActive=false},
                new SubscriptionPeriod{SubscriptionPeriodID=28,StartDate=Convert.ToDateTime("2024-06-12"),
                    EndDate=Convert.ToDateTime("2024-07-12"),Fees=300.0000M,Paid=true,MemberID=36,PaymentID=24,IssueReason=1,SubscrpitonDays=30,IsActive=false},
                new SubscriptionPeriod{SubscriptionPeriodID=29,StartDate=Convert.ToDateTime("2024-06-12"),
                    EndDate=Convert.ToDateTime("2024-07-12"),Fees=300.0000M,Paid=true,MemberID=37,PaymentID=null,IssueReason=1,SubscrpitonDays=30,IsActive=false},
                new SubscriptionPeriod{SubscriptionPeriodID=30,StartDate=Convert.ToDateTime("2024-06-12"),
                    EndDate=Convert.ToDateTime("2024-07-12"),Fees=60.0000M,Paid=true,MemberID=21,PaymentID=26,IssueReason=2,SubscrpitonDays=38,IsActive=false},
                new SubscriptionPeriod{SubscriptionPeriodID=31,StartDate=Convert.ToDateTime("2024-06-12"),
                    EndDate=Convert.ToDateTime("2024-07-12"),Fees=60.0000M,Paid=true,MemberID=21,PaymentID=27,IssueReason=2,SubscrpitonDays=38,IsActive=false},
                new SubscriptionPeriod{SubscriptionPeriodID=33,StartDate=Convert.ToDateTime("2025-01-25"),
                    EndDate=Convert.ToDateTime("2025-02-23"),Fees=35.0000M,Paid=true,MemberID=21,PaymentID=27,IssueReason=2,SubscrpitonDays=34,IsActive=true},
            
        };
        }
    }
}
