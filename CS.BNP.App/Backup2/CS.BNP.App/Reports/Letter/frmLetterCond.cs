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
    public partial class frmLetterCond : Form
    {
        public frmLetterCond()
        {
            InitializeComponent();
        }
        Entity.CSBNPEntities db = new Entity.CSBNPEntities();
        Services.GlobalService gloService = new Services.GlobalService();
        private void ClearForm()
        {
            BindingControl();
            this.cbDebitorPeriod.SelectedIndex = 0;
        }
        private void BindingControl()
        {
            var _tmp = db.mas_DebitorBillingPeriod.ToList();
            var data = _tmp.OrderBy(o => o.ID).Select(s => new
            {
                val = s.ID,
                txt = s.DebitorPeriodCode + " : " + s.DebitorDateFrom.ToString("dd.MM.yyyy", Variable.cul) + " - " + s.DebitorDateTo.ToString("dd.MM.yyyy", Variable.cul)
            }).ToList();
            data.Insert(0, new { val = 0, txt = "-- เลือกช่วงเวลาการตั้งเบิกลูกหนี้ --" });
            this.cbDebitorPeriod.DataSource = data;
            this.cbDebitorPeriod.DisplayMember = "txt";
            this.cbDebitorPeriod.ValueMember = "val";
            
        }
        public void DGV()
        {
            if (this.cbDebitorPeriod.SelectedIndex > 0)
            {
                int _condition = int.Parse(this.cbDebitorPeriod.SelectedValue.ToString());
                var tmpdata = db.vwrpt_TransactionDebitor_new.Where(w => w.DebitorPeriodID == _condition).AsEnumerable().Select((s, inx) => new
                {
                    iNo = inx + 1,
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
                    TranUnit = s.TranUnit
                }).ToList();

                var data = tmpdata.GroupBy(g => new
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
                    TranUnit = g.TranUnit
                }).Select(s => new
                {
                    DebitorID = s.Key.DebitorID,
                    DebitorName = s.Key.DebitorName,
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
                    TotalAmount = s.Sum(sm=> sm.TotalAmount),
                    bCount = s.Count(),
                    TranUnitQuantityCr = s.Count(),
                    TranVat = s.Sum(sm => sm.TranVat),
                    TransactionDate = s.Key.TransactionDate,
                    NetAmount = s.Sum(sm => sm.TranVat + sm.TotalAmount),
                    TranUnit = s.Key.TranUnit
                }).ToList();
            
                this.gridControl.DataSource = data.OrderBy(o=>o.ProductID);
                this.gridControl.ForceInitialize();

                ControlBTN(this.gridView.RowCount > 0);
            }
            else
            {
                ControlBTN(false);
            }
        }
        private void ControlBTN(bool v)
        {
            this.btnReport.Visible = v; this.btnBillDetail.Visible = v; this.btnEachDay.Visible = v;
        }
        private void frmLetterCond_Load(object sender, EventArgs e)
        {
            ClearForm();
            this.cbDebitorPeriod.Select();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (this.gridView.RowCount == 0)
            {
                gloService.Announce("ไม่มีข้อมูลในการออกรายงาน .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                this.cbDebitorPeriod.Select(); return;
            }
            else
            {
                frmLetterViewer rptViewer = new frmLetterViewer();
                rptViewer.keyId = int.Parse(this.cbDebitorPeriod.SelectedValue.ToString());
                rptViewer.jobId = int.Parse(this.cbJob.SelectedValue.ToString()); rptViewer.debitorId = int.Parse(this.cbDebitor.SelectedValue.ToString());
                rptViewer.PrintLetter();
                rptViewer.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbDebitorPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnReport.Visible = this.cbDebitorPeriod.SelectedIndex > 0;
            DGV();

            if (this.cbDebitorPeriod.SelectedIndex > 0)
            {
                int _dp = int.Parse(this.cbDebitorPeriod.SelectedValue.ToString());  
                var dataD = db.tran_DebitorRecDetail.Where(w=>w.tran_DebitorRec.DebitorPeriodID == _dp).OrderBy(o => o.ID).Select(s => new
                {
                    val = s.tran_DebitorRec.DebitorID,
                    txt = s.tran_DebitorRec.mas_Debtor.DebtorName + " : " + s.tran_DebitorRec.mas_Debtor.DebtorCode
                }).Distinct().ToList();
                dataD.Insert(0, new { val = 0, txt = "-- เลือกลูกหนี้ --" });
                this.cbDebitor.DataSource = dataD;
                this.cbDebitor.DisplayMember = "txt";
                this.cbDebitor.ValueMember = "val";

                var dataJob = db.tran_DebitorRecDetail.Where(w => w.tran_DebitorRec.DebitorPeriodID == _dp).OrderBy(o => o.ID).Select(s => new
                {
                    val = s.tran_DebitorRec.JobID,
                    txt = s.tran_Creditor.mas_Job.JobName + " : " + s.tran_Creditor.mas_Job.JobCode
                }).Distinct().ToList();
                dataJob.Insert(0, new { val = 0, txt = "-- เลือกโครงการ --" });
                this.cbJob.DataSource = dataJob;
                this.cbJob.DisplayMember = "txt";
                this.cbJob.ValueMember = "val";
            }
            else
            {
                this.cbJob.DataSource = null; this.cbDebitor.DataSource = null;
            }            
        }

        private void btnBillDetail_Click(object sender, EventArgs e)
        {
            if (this.gridView.RowCount == 0)
            {
                gloService.Announce("ไม่มีข้อมูลในการออกรายงาน .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                this.cbDebitorPeriod.Select(); return;
            }
            else
            {
                frmBillDetailViewer rptViewer = new frmBillDetailViewer();
                rptViewer.keyId = int.Parse(this.cbDebitorPeriod.SelectedValue.ToString());
                rptViewer.jobId = int.Parse(this.cbJob.SelectedValue.ToString()); rptViewer.debitorId = int.Parse(this.cbDebitor.SelectedValue.ToString());
                rptViewer.PrintBillDetail();
                rptViewer.Show();
            }
        }

        private void btnEachDay_Click(object sender, EventArgs e)
        {
            if (this.gridView.RowCount == 0)
            {
                gloService.Announce("ไม่มีข้อมูลในการออกรายงาน .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                this.cbDebitorPeriod.Select(); return;
            }
            else
            {
                frmBillEachDayViewer rptViewer = new frmBillEachDayViewer();
                rptViewer.keyId = int.Parse(this.cbDebitorPeriod.SelectedValue.ToString());
                rptViewer.jobId = int.Parse(this.cbJob.SelectedValue.ToString()); rptViewer.debitorId = int.Parse(this.cbDebitor.SelectedValue.ToString());
                rptViewer.PrintBillEachDay();
                rptViewer.Show();
            }
        }
    }
}
