using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Entity
{
    public class Member : Person
    {
        public string? EmergencyContactInfo { get; set; }

        public int LastBeltRankID { get; set; }
        public virtual BeltRank BeltRank { get; set; } = null!;

        public bool IsActive { get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();
        public virtual ICollection<MemberInstructor> MemberInstructors { get; set; } = new List<MemberInstructor>();
        public virtual ICollection<SubscriptionPeriod> SubscriptionPeriods { get; set; } = new List<SubscriptionPeriod>();
        public virtual ICollection<BeltTest> BeltTests { get; set; } = new List<BeltTest>();
        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();


    }
}
