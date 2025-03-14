using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Entity
{
    public class BeltTest
    {
        public int BeltTestID { get; set; }
        public int MemberID { get; set; }
        public virtual Member Member { get; set; } = null!;
        public int BeltRankID { get; set; }
        public virtual BeltRank BeltRank { get; set; } = null!;
        public int InstructorID { get; set; }
        public virtual Instructor Instructor { get; set; } = null!;
        public int? PaymentID { get; set; }
        public virtual  Payment? Payment { get; set; } = null!;  
        public bool Result { get; set; }
        public DateTime Date { get; set; }

    }
}
