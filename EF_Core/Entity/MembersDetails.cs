using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Entity
{
    public class MembersDetails
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gender { get; set; }
        public string? Email { get; set; }
        public string? EmergencyContactInfo { get; set; }
        public string? RankName { get; set; }
        public bool IsActive { get; set; }
        private string GetGender()
        {
            return Gender==1?"Male":"Female";
        }
        private string GetEmail()
        {
            return Email==null ? "No Email" : Email;
        }
        private string GetIsActive()
        {
            return IsActive ? "Active" : "Not Active";
        }
        public override string ToString()
        {
            return $"Name= {Name}, Address= {Address}, Phone= {Phone}, Birht Date= {DateOfBirth}, Gender= {GetGender()},Email= {GetEmail()}," +
                $" Emergency Contact Info= {EmergencyContactInfo}, Rank Name= {RankName}, IsActive= {GetIsActive()}";
        }
    }
}
