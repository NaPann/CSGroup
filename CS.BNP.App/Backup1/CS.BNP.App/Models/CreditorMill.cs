using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.BNP.App.Models
{
    public class CreditorMill
    {
        public int id { get; set; }
        public int tran_id { get; set; }
        public int creditormilll_id { get; set; }
        public string creditormill_code { get; set; }
        public string creditormill_name { get; set; }
        public bool is_vat { get; set; }
        public decimal vat_int { get; set; }
        public decimal vat_amount { get; set; }
        public decimal net_amount { get; set; }
        public decimal total_amount { get; set; }
        public string remark { get; set; }

        public decimal exAmount { get; set; }
    }
}
