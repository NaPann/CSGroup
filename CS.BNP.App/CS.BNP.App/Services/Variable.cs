using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.BNP.App.Services
{
    public static class Variable
    {
        public static string AppVersion = "V.240502";
        public static Models.UserProfile CurrentProfile { get; set; }
        public static byte chPass { get; set; }
        public static System.Globalization.CultureInfo cul = new System.Globalization.CultureInfo("en-us");
        public static System.Globalization.CultureInfo culTH = new System.Globalization.CultureInfo("th-th");
    }
}
