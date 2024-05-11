using CS.BNP.App.Services;
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
    public partial class frmLetterViewer : DevExpress.XtraEditors.XtraForm
    {
        public frmLetterViewer()
        {
            InitializeComponent();
        }
        public int keyId = 0; public int secondKeyId = 0;

        public int jobId = 0; public int debitorId = 0;

		//new cond
		public string docNo = "";

		//show PO
		public bool showPO = true;

        public int[] tranCreditorId; public DateTime dtStart; public DateTime dtEnd;

        Entity.CSBNPEntities db = new Entity.CSBNPEntities();
        public void PrintLetter()
        {
            var tmp = db.vwrpt_TransactionDebitor_new.Where(w => w.DebitorPeriodID == keyId).ToList();
            if (jobId > 0)
                tmp = tmp.Where(w => w.JobID == jobId).ToList();

            if (debitorId > 0)
                tmp = tmp.Where(w => w.DebitorID == debitorId).ToList();

            var _jobDetail = db.mas_JobDetail.ToList();
            if (jobId > 0)
                _jobDetail = _jobDetail.Where(w => w.JobID == jobId).ToList();

			if (!string.IsNullOrWhiteSpace(docNo))
				tmp = tmp.Where(w => w.DocNo == docNo).ToList();

			var tmpdataLetter = tmp.Where(w => w.DebitorPeriodID == keyId).AsEnumerable().Select((s, inx) => new
            {
                iNo = inx + 1,
                CheckedBy = s.CheckedBy,
                DebitorID = s.DebitorID,
                DebitorName = s.DebtorName,
                DebitorPeriodID = s.DebitorPeriodID,
                DebitorPeriodCode = s.DebitorPeriodCode,
                DebitorDateFrom = s.DebitorDateFrom,                
                DebitorDateTo = s.DebitorDateTo,
                TransactionDate = s.TransactionDate,
                JobID = s.JobID,
                JobName = s.JobName,
                ProductID = s.ProductID,
                ProductName = s.ProductName,
                ProductCode = s.ProductCode,
                TranWeight = s.TranWeight,
                TranSellPrice = s.TranSellPrice,
                TotalAmount = s.TranSellPrice * s.TranWeight,
                TranVat = (s.TranVat / 100) * (s.TranSellPrice * s.TranWeight),
                DocNo = s.DocNo,
                IsVat = s.IsVat,
                TranVatCr = s.TranVat,
                TranDiscount = s.TranDiscount,
                TotalAmountByBill = s.TotalAmountByBill,
                DebtorTaxID = s.DebtorTaxID,
                DebtorAddress = s.DebtorAddress,
                TranUnit = s.TranUnit,
                Reference = s.Reference,
                s.CreditorContact
            }).ToList();

            var dataLetter = tmpdataLetter.GroupBy(g => new
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
                CheckedBy = g.CheckedBy,
                IsVat = g.IsVat,
                TranVatCr = g.TranVatCr,
                //TranDiscount = g.TranDiscount,
                //TotalAmountByBill = g.TotalAmountByBill,
                DebtorTaxID = g.DebtorTaxID,
                DebtorAddress = g.DebtorAddress,
                TranUnit = g.TranUnit,
                Reference = g.Reference,
                DocNo = g.DocNo
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
                TranUnitQuantityCr = s.Select(sp=>sp.DocNo).Count(),
                DocNo = s.Key.DocNo,
                TranVat = s.Sum(sm => sm.TranVat),
                TransactionDate = s.Key.TransactionDate,
                CheckedBy = s.Key.CheckedBy,
                IsVat = s.Key.IsVat,
                TranVatCr = s.Key.TranVatCr,
                TranDiscount = s.Sum(sm=>sm.TranDiscount),
                TotalAmountByBill = s.Sum(sm => sm.TotalAmount) + (s.Sum(sm => sm.TranDiscount) / 100),
				DebtorTaxID = s.Key.DebtorTaxID,
                DebtorAddress = s.Key.DebtorAddress,
                TranUnit = s.Key.TranUnit,
                Reference = s.Key.Reference,
                Driver = int.Parse(s.Key.DebitorDateFrom.ToString("dd", Variable.culTH)).ToString() + " - " + s.Key.DebitorDateTo.ToString("dd MMM yy", Variable.culTH),
                CreditorContact = ((_jobDetail.Where(w=>w.JobID == s.Key.JobID && w.ProductID == s.Key.ProductID).FirstOrDefault() == null ? 0 
                : _jobDetail.Where(w => w.JobID == s.Key.JobID && w.ProductID == s.Key.ProductID).FirstOrDefault().JobQuantity)
                - db.tran_Creditor.Where(w => w.ProductID == s.Key.ProductID && w.JobID == s.Key.JobID).Sum(ss => ss.TranWeight)).ToString("#,0.00")
        }).ToList();

            Reports.Letter.rptLetterFirst rptLetter = new Letter.rptLetterFirst();
            rptLetter.DataSource = dataLetter;

            //Show PO
            rptLetter.lblShowPO.Visible = this.showPO;

            documentViewer1.DocumentSource = rptLetter;
            rptLetter.CreateDocument();
        }
        private void frmLetterViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
