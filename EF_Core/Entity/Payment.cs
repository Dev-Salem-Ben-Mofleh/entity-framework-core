using EF_Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Entity
{
    public class Payment
    {
        public int PaymentID { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public int MemberID { get; set; }
        public virtual Member Member { get; set; } = null!;

        public PaymentFor PaymentFor { get; set; }

        public virtual BeltTest BeltTest { get; set; } = null!;
    }
}
