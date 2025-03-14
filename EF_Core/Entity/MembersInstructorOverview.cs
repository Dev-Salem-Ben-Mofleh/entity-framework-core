using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Entity
{
    public class MembersInstructorOverview
    {
        public int MemberInstructorID { get; set; }
        public string? MemberName { get; set; }
        public string? InstroctureName { get; set; }
        public string? RankName { get; set; }
        public DateTime AssignDate { get; set; }
        public override string ToString()
        {
            return $"MemberInstructor ID= {MemberInstructorID}, Member Name= {MemberName}, Instrocture Name= {InstroctureName}, Rank Name= {RankName}, Assign Date= {AssignDate}";
        }

    }



}
