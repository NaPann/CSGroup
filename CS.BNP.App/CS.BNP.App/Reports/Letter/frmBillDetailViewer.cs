using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS.BNP.App.Reports.Letter
{
    public partial class frmBillDetailViewer : DevExpress.XtraEditors.XtraForm
    {
        public frmBillDetailViewer()
        {
            InitializeComponent();
        }
        public int keyId = 0; public int secondKeyId = 0;
        public int jobId = 0; public int debitorId = 0;

		//new cond
		public string docNo = "";

		public int[] tranCreditorId; public DateTime dtStart; public DateTime dtEnd;
        Entity.CSBNPEntities db = new Entity.CSBNPEntities();
        public void PrintBillDetail()
        {
            var tmp = db.vwrpt_TransactionDebitor_new.Where(w => w.DebitorPeriodID == keyId).ToList();
            if (jobId > 0)
                tmp = tmp.Where(w => w.JobID == jobId).ToList();

            if (debitorId > 0)
                tmp = tmp.Where(w => w.DebitorID == debitorId).ToList();

			if (!string.IsNullOrWhiteSpace(docNo))
				tmp = tmp.Where(w => w.DocNo == docNo).ToList();

			var tmpdataLetter = tmp.Where(w => w.DebitorPeriodID == keyId).AsEnumerable().Select((s, inx) => new
            {
                iNo = inx + 1,
                DebitorID = s.DebitorID,
                DebitorName = s.DebtorName,
                DebitorPeriodID = s.DebitorPeriodID,
                DebitorPeriodCode = s.DebitorPeriodCode,
                DebitorDateFrom = s.DebitorDateFrom,
                DebitorDateTo = s.DebitorDateTo,
                TransactionDate = s.TransactionDateCr,
                JobID = s.JobID,
                JobName = s.JobName,
                ProductID = s.ProductID,
                ProductName = s.ProductName,
                ProductCode = s.ProductCode,
                TranWeight = s.TranWeight,
                TranSellPrice = s.TranSellPrice,
                TotalAmount = s.TranSellPrice * s.TranWeight,
                TranVat = (s.TranVat / 100) * (s.TranSellPrice * s.TranWeight),
                TranUnit = s.TranUnit,
                DocNo = s.DocNo,
            }).ToList();

            var dataBillDetail = tmpdataLetter.GroupBy(g => new
            {
                DebitorID = g.DebitorID,
                DebitorName = g.DebitorName,
                DebitorPeriodID = g.DebitorPeriodID,
                DebitorPeriodCode = g.DebitorPeriodCode,
                DebitorDateFrom = g.DebitorDateFrom,
                DebitorDateTo = g.DebitorDateTo,
                JobID = g.JobID,
                JobName = g.JobName,
                ProductID = g.ProductID,
                ProductName = g.ProductName,
                ProductCode = g.ProductCode,
                TranSellPrice = g.TranSellPrice,
                TransactionDate = g.TransactionDate,
                TranUnit = g.TranUnit,
                DocNo = g.DocNo,
            }).Select(s => new
            {
                DebitorID = s.Key.DebitorID,
                DebtorName = s.Key.DebitorName,
                DebitorPeriodID = s.Key.DebitorPeriodID,
                DebitorPeriodCode = s.Key.DebitorPeriodCode,
                DebitorDateFrom = s.Key.DebitorDateFrom,
                DebitorDateTo = s.Key.DebitorDateTo,
                JobID = s.Key.JobID,
                JobName = s.Key.JobName,
                ProductID = s.Key.ProductID,
                ProductName = s.Key.ProductName,
                ProductCode = s.Key.ProductCode,
                TranSellPrice = s.Key.TranSellPrice,
                TranWeight = s.Sum(sm => sm.TranWeight),
                TotalAmount = s.Sum(sm => sm.TotalAmount),
                TranUnitQuantityCr = s.Count(),
                TranVat = s.Sum(sm => sm.TranVat),
                TransactionDate = s.Key.TransactionDate,
                DocNo = s.Key.DocNo,
                TranUnit = s.Key.TranUnit
            }).ToList();

            Reports.Letter.rptBillDetail rptBillDetail = new Letter.rptBillDetail();
            rptBillDetail.DataSource = dataBillDetail;
            documentViewer1.DocumentSource = rptBillDetail;
            rptBillDetail.CreateDocument();
        }
        private void frmBillDetailViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
