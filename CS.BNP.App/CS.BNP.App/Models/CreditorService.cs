using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.BNP.App.Models
{
    public class CreditorService
    {
        public int id { get; set; }
        public int tran_id { get; set; }
        public int creditorService_id { get; set; }
        public string creditorService_code { get; set; }
        public string creditorService_name { get; set; }

        public int productService_id { get; set; }

        public bool is_vat { get; set; }
        public bool is_atvat { get; set; }

        public decimal vat_int { get; set; }
        public decimal atvat_int { get; set; }

        public decimal vat_amount { get; set; }
        public decimal atvat_amount { get; set; }

        public decimal net_amount { get; set; }
        public decimal total_amount { get; set; }
        public string remark { get; set; }

        public decimal exAmount { get; set; }
    }
}
