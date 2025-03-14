using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Entity
{
    public class User:Person
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public bool IsActive { get; set; }
        public byte Permission { get; set; }


    }
}
