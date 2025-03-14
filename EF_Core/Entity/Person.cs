using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EF_Core.Entity
{
    public class Person
    {
        public int PersonID { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gender { get; set; }
        public string? Email { get; set; }

    }
}
