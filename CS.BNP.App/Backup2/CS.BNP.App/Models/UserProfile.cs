using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.BNP.App.Models
{
    public class UserProfile
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public bool is_security { get; set; }
        public bool is_systemsetup { get; set; }
        public bool is_transection { get; set; }
        public bool is_report { get; set; }
        public bool is_admin { get; set; }

    }
}
