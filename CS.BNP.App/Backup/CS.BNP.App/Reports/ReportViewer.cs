using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CS.BNP.App.Services;

namespace CS.BNP.App.Reports
{
    public partial class ReportViewer : DevExpress.XtraEditors.XtraForm
    {
        public ReportViewer()
        {
            InitializeComponent();
        }
        public int keyId = 0; public int secondKeyId = 0;
        public int[] tranCreditorId; public DateTime dtStart; public DateTime dtEnd;
        Entity.CSBNPEntities db = new Entity.CSBNPEntities();

        public IFormatProvider Variabl { get; private set; }

        public void PrintReport(ReportType reportType)
        {
            switch (reportType)
            {
                case ReportType.SummaryCreditor:
                    var dataSummaryCreditor = db.vwrpt_TransactionCreditor.Where(w => w.BillingPeriodID == keyId).ToList();
                    Reports.TransactionCreditor.rptTranCreditor rptSumTranCr = new TransactionCreditor.rptTranCreditor();
                    rptSumTranCr.DataSource = dataSummaryCreditor;
                    documentViewer1.DocumentSource = rptSumTranCr;
                    rptSumTranCr.CreateDocument();
                    break;
                case ReportType.SummaryDebitor:
                    var dataSummaryDebitor = db.vwrpt_TransactionDebitor_new.Where(w => w.DebitorPeriodID == keyId).ToList();
                    Reports.TransactionDebitor.rptTranDebitor rptSumTranDr = new TransactionDebitor.rptTranDebitor();
                    rptSumTranDr.DataSource = dataSummaryDebitor;
                    documentViewer1.DocumentSource = rptSumTranDr;
                    rptSumTranDr.CreateDocument();
                    break;
                case ReportType.ReportCreditor:
                    var tmpData = db.vwrpt_SumTransactionCreditor.ToList();
                    if (keyId > 0)
                    {
                        tmpData = tmpData.Where(w => w.BillingPeriodID == keyId).ToList();
                    }
                    if (secondKeyId > 0)
                    {
                        tmpData = tmpData.Where(w => w.CreditorID == secondKeyId).ToList();
                    }

                    TransactionCreditor.rptReportingCreditior rptReportCr = new TransactionCreditor.rptReportingCreditior();
                    rptReportCr.DataSource = tmpData;
                    documentViewer1.DocumentSource = rptReportCr;
                    rptReportCr.CreateDocument();
                    break;
                case ReportType.ReportDebitor:
                    var tmpSummDR = db.vwrpt_TransactionDebitor_new.ToList();
                    if (keyId > 0)
                    {
                        tmpSummDR = tmpSummDR.Where(w => w.DebitorPeriodID == keyId).ToList();
                    }
                    if (secondKeyId > 0)
                    {
                        tmpSummDR = tmpSummDR.Where(w => w.DebitorID == secondKeyId).ToList();
                    }
                    TransactionDebitor.rptSummaryCompare rptSummDR = new TransactionDebitor.rptSummaryCompare();
                    rptSummDR.DataSource = tmpSummDR;
                    documentViewer1.DocumentSource = rptSummDR;
                    rptSummDR.CreateDocument();
                    break;
                case ReportType.BuyVat:
                    var tmpdata = db.vwrpt_TransactionCreditor.Where(w => w.TransactionDate >= dtStart
      && w.TransactionDate <= dtEnd && w.TranVat > 0).AsEnumerable().Select((s, inx) => new
      {
          iNo = inx + 1,
          TransactionDate = s.TransactionDate,
          CreditorID = s.CreditorID,
          CreditorName = s.CreditorName,
          TotalAmount = s.TranWeight * s.TranBuyPrice,
          Vat = s.TranVat / 100,
          VatAmount = (s.TranWeight * s.TranBuyPrice) * (s.TranVat / 100)
      }).ToList();

                    var dataBuyVat = tmpdata.GroupBy(g => new
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
                        TranVat = s.Sum(sm => sm.VatAmount),
                        TotalAmount = s.Sum(sm => sm.TotalAmount),
                        TranUnitQuantity = s.Sum(sm => sm.VatAmount + sm.TotalAmount)
                    }).ToList();
                    Reports.TransactionCreditor.rptBuyVat rptBuyVat = new TransactionCreditor.rptBuyVat();
                    rptBuyVat.DataSource = dataBuyVat;
                    documentViewer1.DocumentSource = rptBuyVat;
                    rptBuyVat.CreateDocument();
                    break;

                case ReportType.VS:
                    var tmpdataX = db.vwrpt_VersusBuySell.Where(w => w.SellDate >= dtStart
      && w.SellDate <= dtEnd).OrderBy(o => o.SellDate).AsEnumerable().Select((s, inx) => new
      {
          s.DebtorCode,
          s.DebtorName,
          s.JobID,
          s.JobCode,
          s.JobName,
          s.ProductCode,
          s.ProductName,
          s.TranSellPrice,
          s.TranUnit,
          s.CreditorCode,
          s.CreditorName,
          s.TranBuyPrice,
          s.SellDate
      }).Distinct().ToList();

                    var tmpdataVS = tmpdataX.AsEnumerable().Select((s, inx) => new
                    {
                        iNo = inx +1,
                        s.DebtorCode,
                        s.DebtorName,
                        s.JobID,
                        s.JobCode,
                        s.JobName,
                        s.ProductCode,
                        s.ProductName,
                        s.TranSellPrice,
                        s.TranUnit,
                        s.CreditorCode,
                        s.CreditorName,
                        s.TranBuyPrice,
                        s.SellDate
                    }).ToList();

                    Reports.VS.rptVS rptS = new VS.rptVS();
                    rptS.xrFrom.Text = dtStart.ToString("dd MMM yyyy", Variable.culTH);
                    rptS.xrTo.Text = dtEnd.ToString("dd MMM yyyy", Variable.culTH);
                    rptS.DataSource = tmpdataVS;
                    documentViewer1.DocumentSource = rptS;
                    rptS.CreateDocument();
                    break;

                case ReportType.VSJob:
                    var tmpdataBASE = db.vwrpt_VersusBuySellFromJob.Where(w => w.TransactionDate >= dtStart
      && w.TransactionDate <= dtEnd).OrderBy(o => o.TransactionDate).AsEnumerable().Select((s, inx) => new
      {
          s.DebtorCode,
          s.DebtorName,
          s.JobID,
          s.JobCode,
          s.JobName,
          s.ProductCode,
          s.ProductName,
          s.SellPrice,
          s.ProductUnit,
          s.CreditorCode,
          s.CreditorName,
          s.BuyPrice,
          s.TransactionDate
      }).Distinct().ToList();

                    var tmpdataVSJob = tmpdataBASE.AsEnumerable().Select((s, inx) => new
                    {
                        iNo = inx + 1,
                        s.DebtorCode,
                        s.DebtorName,
                        s.JobID,
                        s.JobCode,
                        s.JobName,
                        s.ProductCode,
                        s.ProductName,
                        s.SellPrice,
                        s.ProductUnit,
                        s.CreditorCode,
                        s.CreditorName,
                        s.BuyPrice,
                        s.TransactionDate,
                        TransactionDateStr = s.TransactionDate.ToString("dd/MMM/yy", Variable.culTH)
                    }).ToList();

                    Reports.VS.rptVSBase rptVSBase = new VS.rptVSBase();
                    rptVSBase.xrFrom.Text = dtStart.ToString("dd MMM yyyy", Variable.culTH);
                    rptVSBase.xrTo.Text = dtEnd.ToString("dd MMM yyyy", Variable.culTH);
                    rptVSBase.DataSource = tmpdataVSJob;
                    documentViewer1.DocumentSource = rptVSBase;
                    rptVSBase.CreateDocument();
                    break;

                default:
                    break;
            }
        }
        private void ReportViewer_Load(object sender, EventArgs e)
        {

        }
    }

    public enum ReportType
    {
        SummaryCreditor, SummaryDebitor,
        ReportCreditor, ReportDebitor, BuyVat, Letter, VS, VSJob
    }
}