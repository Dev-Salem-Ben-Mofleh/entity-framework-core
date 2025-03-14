using EF_Core.Entity;
using EF_Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Core.Data.config
{
    public class ConfigrationPayment : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(x => x.PaymentID);
            builder.Property(x => x.PaymentID).ValueGeneratedNever();
            builder.Property(x => x.Amount).HasPrecision(10, 2);
            builder.Property(x => x.PaymentFor).HasConversion(x => ((byte)x),
                x => (PaymentFor) x);

           builder.HasData(LoadPayments());
            builder.ToTable("Payments");
        }
        public static List<Payment> LoadPayments()
        {
            return new List<Payment>
            {
               new Payment{PaymentID=1,Amount=20.00M,Date=Convert.ToDateTime("2024-05-06"),MemberID=3,PaymentFor= PaymentFor.FirstTime},
               new Payment{PaymentID=6,Amount=60.00M,Date=Convert.ToDateTime("2024-06-10"),MemberID=21,PaymentFor=PaymentFor.FirstTime },
               new Payment{PaymentID=14,Amount=50.00M,Date=Convert.ToDateTime("2024-06-10"),MemberID=3,PaymentFor=PaymentFor.FirstTime },
               new Payment{PaymentID=17,Amount=60.00M,Date=Convert.ToDateTime("2024-06-11"),MemberID=3,PaymentFor=PaymentFor.Renew },
               new Payment{PaymentID=18,Amount=60.00M,Date=Convert.ToDateTime("2024-06-11"),MemberID=3,PaymentFor=PaymentFor.Renew },
               new Payment{PaymentID=19,Amount=60.00M,Date=Convert.ToDateTime("2024-06-11"),MemberID=3,PaymentFor=PaymentFor.Renew},
               new Payment{PaymentID=20,Amount=60.00M,Date=Convert.ToDateTime("2024-06-11"),MemberID=3,PaymentFor=PaymentFor.Renew },
               new Payment{PaymentID=21,Amount=70.00M,Date=Convert.ToDateTime("2024-06-11"),MemberID=3,PaymentFor=PaymentFor.Renew },
               new Payment{PaymentID=22,Amount=200.00M,Date=Convert.ToDateTime("2024-06-12"),MemberID=39,PaymentFor=PaymentFor.FirstTime },
               new Payment{PaymentID=23,Amount=400.00M,Date=Convert.ToDateTime("2024-06-12"),MemberID=38,PaymentFor=PaymentFor.FirstTime },
               new Payment{PaymentID=24,Amount=300.00M,Date=Convert.ToDateTime("2024-06-12"),MemberID=36,PaymentFor=PaymentFor.FirstTime },
               new Payment{PaymentID=25,Amount=70.00M,Date=Convert.ToDateTime("2024-06-12"),MemberID=21,PaymentFor=PaymentFor.FirstTime },
               new Payment{PaymentID=26,Amount=60.00M,Date=Convert.ToDateTime("2024-06-12"),MemberID=21,PaymentFor=PaymentFor.FirstTime },
               new Payment{PaymentID=27,Amount=60.00M,Date=Convert.ToDateTime("2024-06-12"),MemberID=21,PaymentFor=PaymentFor.FirstTime },
               new Payment{PaymentID=32,Amount=110.00M,Date=Convert.ToDateTime("2024-06-12"),MemberID=38,PaymentFor=PaymentFor.Renew},
               new Payment{PaymentID=33,Amount=120.00M,Date=Convert.ToDateTime("2024-06-12"),MemberID=38,PaymentFor=PaymentFor.Renew },
               new Payment{PaymentID=34,Amount=130.00M,Date=Convert.ToDateTime("2024-06-12"),MemberID=38,PaymentFor=PaymentFor.Renew },
               new Payment{PaymentID=35,Amount=50.00M,Date=Convert.ToDateTime("2024-06-12"),MemberID=39,PaymentFor=PaymentFor.Renew },
               new Payment{PaymentID=36,Amount=50.00M,Date=Convert.ToDateTime("2024-06-12"),MemberID=39,PaymentFor=PaymentFor.Renew },
               new Payment{PaymentID=37,Amount=60.00M,Date=Convert.ToDateTime("2024-06-12"),MemberID=39,PaymentFor=PaymentFor.Renew },
               new Payment{PaymentID=38,Amount=70.00M,Date=Convert.ToDateTime("2024-06-13"),MemberID=39,PaymentFor=PaymentFor.Renew }



        };
        }

    }
}
