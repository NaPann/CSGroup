using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS.BNP.App.Reports.Mills
{
    public partial class frmMillVat : Form
    {
        public frmMillVat()
        {
            InitializeComponent();
        }
        Entity.CSBNPEntities db = new Entity.CSBNPEntities();
        Services.GlobalService gloService = new Services.GlobalService();
        private int[] TranCreId; private DateTime DTStart; private DateTime DTEnd;
        private void ClearForm()
        {
            this.dtpMonth.Value = DateTime.Now;
        }
        public void DGV()
        {
            DateTime _dateStart = new DateTime(this.dtpMonth.Value.Year, this.dtpMonth.Value.Month, 1);
            DateTime _dateEnd = _dateStart.AddMonths(1).AddDays(-1);

            var tmpdata = db.vwrpt_TransactionCreditor.Where(w => w.TransactionDate >= _dateStart
     && w.TransactionDate <= _dateEnd && w.TranVat > 0).AsEnumerable().Select((s, inx) => new
     {
         iNo = inx + 1,
         TransactionDate = s.TransactionDate,
         CreditorID = s.CreditorID,
         CreditorName = s.CreditorName,
         TotalAmount = s.TranWeight * s.TranBuyPrice,
         Vat = s.TranVat / 100,
         VatAmount = (s.TranWeight * s.TranBuyPrice) * (s.TranVat / 100)
     }).ToList();

            var data = tmpdata.Where(w => w.TransactionDate >= _dateStart
            && w.TransactionDate <= _dateEnd).GroupBy(g => new
            {
                TransactionDate = g.TransactionDate,
                CreditorID = g.CreditorID,
                CreditorName = g.CreditorName,
            }).AsEnumerable().Select((s, inx) => new
            {
                iNo = inx + 1,
                TransactionDate = s.Key.TransactionDate,
                CreditorID = s.Key.CreditorID,
                CreditorName = s.Key.CreditorName,
                TotalVat = s.Sum(sm => sm.VatAmount),
            }).ToList();

            //  var data = db.vwrpt_TransactionCreditor.Where(w => w.TransactionDate >= _dateStart
            //&& w.TransactionDate <= _dateEnd).AsEnumerable().Select((s, inx) => new
            //{
            //    iNo = inx + 1,
            //    TransactionDate = s.TransactionDate,
            //    CreditorID = s.CreditorID,
            //    CreditorName = s.CreditorName,
            //    TotalVat = s.TranWeight * s.TranBuyPrice,
            //    TotalAmount = s.TranVat / 100,
            //    ShowVat = (s.TranWeight * s.TranBuyPrice) * (s.TranVat / 100)
            //}).ToList();

            this.gridControl.DataSource = data;
            this.gridControl.ForceInitialize();

            DTStart = _dateStart; DTEnd = _dateEnd;

            ControlBTN(this.gridView.RowCount > 0);
        }
        private void ControlBTN(bool v)
        {
            this.btnReport.Visible = v; this.btnExport.Visible = v;
        }
        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        private void frmMillVat_Load(object sender, EventArgs e)
        {

        }
    }
}
