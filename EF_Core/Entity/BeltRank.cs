using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace EF_Core.Entity
{
    public class BeltRank
    {
        public int? BeltRankID { get; set; }
        public string? RankName { get; set; }
        public decimal TestFees { get; set; }
        public virtual ICollection<Member> Members { get; set; } = new List<Member>();
        public virtual ICollection<BeltTest> BeltTests { get; set; } = new List<BeltTest>();

    }
}
