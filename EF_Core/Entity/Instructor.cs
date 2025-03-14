using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Entity
{
    public class Instructor:Person
    {
        public string? Qualification { get; set; }
        public virtual ICollection<Member> Members { get; set; } = new List<Member>();
        public virtual ICollection<MemberInstructor> MemberInstructors { get; set; } = new List<MemberInstructor>();
        public virtual ICollection<BeltTest> BeltTests { get; set; } = new List<BeltTest>();

    }
}
