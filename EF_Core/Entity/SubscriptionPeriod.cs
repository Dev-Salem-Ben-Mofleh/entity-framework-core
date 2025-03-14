using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Entity
{
    public class SubscriptionPeriod
    {
        public int SubscriptionPeriodID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Fees { get; set; }
        public bool Paid { get; set; }
        public int MemberID { get; set; }
        public virtual Member Member { get; set; } = null!;
        public int? PaymentID { get; set; }
        public byte IssueReason { get; set; }
        public byte SubscrpitonDays { get; set; }
        public bool IsActive { get; set; }

    }
}
