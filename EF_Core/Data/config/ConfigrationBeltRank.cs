using EF_Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Data.config
{
    public class ConfigrationBeltRank : IEntityTypeConfiguration<BeltRank>
    {
        public void Configure(EntityTypeBuilder<BeltRank> builder)
        {
            builder.HasKey(x => x.BeltRankID);
            builder.Property(x => x.BeltRankID).ValueGeneratedNever();
            builder.Property(x => x.RankName).HasColumnType("VARCHAR").HasMaxLength(50).IsRequired(); ;
            builder.Property(x => x.TestFees).HasPrecision(10, 2);
            builder.HasData(LoadBeltRank());
            builder.ToTable("BeltRanks");
        }
        public static List<BeltRank> LoadBeltRank()
        {
            return new List<BeltRank>
            {
                new BeltRank { BeltRankID=1,RankName= "White Belt",TestFees= 50.0000M },
                new BeltRank { BeltRankID=2,RankName= "Yellow Belt",TestFees= 60.0000M },
                new BeltRank { BeltRankID=3,RankName= "Orange Belt",TestFees= 70.0000M },
                new BeltRank { BeltRankID=4,RankName= "Green Belt",TestFees= 80.0000M },
                new BeltRank { BeltRankID=5,RankName= "Blue Belt",TestFees= 90.0000M },
                new BeltRank { BeltRankID=6,RankName= "Purple Belt",TestFees= 100.0000M },
                new BeltRank { BeltRankID=7,RankName= "Brown Belt",TestFees= 110.0000M },
                new BeltRank { BeltRankID=8,RankName= "Black Belt (1nd Dan)",TestFees= 120.0000M },
                new BeltRank { BeltRankID=9,RankName= "Black Belt (2nd Dan)",TestFees= 130.0000M },
                new BeltRank { BeltRankID=10,RankName= "Black Belt (3nd Dan)",TestFees= 140.0000M },
                new BeltRank { BeltRankID=11,RankName= "Black Belt (4nd Dan)",TestFees= 150.0000M },
                new BeltRank { BeltRankID=12,RankName= "Black Belt (5nd Dan)",TestFees= 160.0000M },
                new BeltRank { BeltRankID=13,RankName= "Black Belt (6nd Dan)",TestFees= 170.0000M },
                new BeltRank { BeltRankID=14,RankName= "Black Belt (7nd Dan)",TestFees= 180.0000M },
                new BeltRank { BeltRankID=15,RankName= "Black Belt (8nd Dan)",TestFees= 190.0000M },
                new BeltRank { BeltRankID=16,RankName= "Black Belt (9nd Dan)",TestFees= 200.0000M },
                new BeltRank { BeltRankID=17,RankName= "Black Belt (10nd Dan)",TestFees= 210.0000M }


        };
        }
    }
}
