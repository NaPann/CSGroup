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
    public partial class frmBillEachDayViewer : Form
    {
        public frmBillEachDayViewer()
        {
            InitializeComponent();
        }
        public int keyId = 0; public int secondKeyId = 0;
        public int jobId = 0; public int debitorId = 0;
        public int[] tranCreditorId; public DateTime dtStart; public DateTime dtEnd;
        Entity.CSBNPEntities db = new Entity.CSBNPEntities();
        public void PrintBillEachDay()
        {
            var tmp = db.vwrpt_TransactionDebitor_new.Where(w => w.DebitorPeriodID == keyId).ToList();
            if (jobId > 0)
                tmp = tmp.Where(w => w.JobID == jobId).ToList();

            if (debitorId > 0)
                tmp = tmp.Where(w => w.DebitorID == debitorId).ToList();

            var tmpdata = tmp.Where(w => w.DebitorPeriodID == keyId).AsEnumerable().Select((s, inx) => new
            {
                iNo = inx + 1,
                DebitorID = s.DebitorID,
                DebtorName = s.DebtorName,
                DebitorPeriodID = s.DebitorPeriodID,
                DebitorPeriodCode = s.DebitorPeriodCode,
                DebitorDateFrom = s.DebitorDateFrom,
                DebitorDateTo = s.DebitorDateTo,
                TransactionDate = s.TransactionDateCr,
                CarLicense = s.CarLicense,
                TransactionSeqCr = s.TransactionSeqCr,
                JobID = s.JobID,
                DocumentNoCr = s.DocumentNoCr,
                JobName = s.JobName,
                ProductID = s.ProductID,
                ProductName = s.ProductName,
                ProductCode = s.ProductCode,
                TranWeight = s.TranWeight,
                TranSellPrice = s.TranSellPrice,
                TotalAmount = s.TranSellPrice * s.TranWeight,
                TranVat = (s.TranVat / 100) * (s.TranSellPrice * s.TranWeight),
                TranUnit = s.TranUnit
            }).ToList();

            Reports.Letter.rptBillEachDay rptLetter = new Letter.rptBillEachDay();
            rptLetter.DataSource = tmpdata;
            documentViewer1.DocumentSource = rptLetter;
            rptLetter.CreateDocument();
        }

        private void frmBillEachDayViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
