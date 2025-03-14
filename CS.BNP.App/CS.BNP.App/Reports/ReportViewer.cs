﻿using System;
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
using CS.BNP.App.Entity;

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

        public List<object> _data;

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

                    //data Remark
                    var tmpRem = db.vwsupport_CreditorRemSUMNEW.ToList();
                    string q = @"SELECT BillingPeriodID, CreditorID, TotalAmount, REM, TranDetail, TranDetailAmt 
  FROM [dbo].[vwsupport_CreditorRemSUMNEW]
  where (1=1)";
                    if (keyId > 0)
                    {
                        tmpRem = tmpRem.Where(w => w.BillingPeriodID == keyId).ToList();
                        q += @" AND  BillingPeriodID = '" + keyId + "'";
                    }
                    if (secondKeyId > 0)
                    {
                        tmpRem = tmpRem.Where(w => w.CreditorID == secondKeyId).ToList();
                        q += @" AND  CreditorID = '" + secondKeyId + "'";
                    }
                 
                    foreach (var item in tmpRem)
                    {
                        item.REM = item.REM.Replace("&#x0D;", "");
                        //if (item.REM.Length > 2)
                        //    item.REM = item.REM.Substring(1);
                    }
                    if (tmpRem.Count() > 0)
                    {
                        tmpData.ForEach(fr => fr.REM = tmpRem.FirstOrDefault().REM.Split('\r').Distinct().FirstOrDefault().Replace("|", "\r"));
                        //tmpData.ForEach(fr => fr.REM = tmpRem.FirstOrDefault().REM);
                        var _tde = db.Database.SqlQuery<vwsupport_CreditorRemSUMNEW>(q).FirstOrDefault();
                        if (_tde != null)
                        {
                            tmpData.ForEach(fr => fr.TranDetail = _tde.TranDetail);
                            tmpData.ForEach(fr => fr.TranDetailAmt = _tde.TranDetailAmt);
                        }
                        tmpData.ForEach(fr => fr.PrepaidTotalAmount = tmpRem.FirstOrDefault().TotalAmount.Value);
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
                        iNo = inx + 1,
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

                    var tmpdataVSJob = tmpdataBASE.AsEnumerable().Select((s, inx) => new VSJOB
                    {
                        iNo = inx + 1,
                        DebtorCode = s.DebtorCode,
                        DebtorName = s.DebtorName,
                        JobID = s.JobID,
                        JobCode = s.JobCode,
                        JobName = s.JobName,
                        ProductCode = s.ProductCode,
                        ProductName = s.ProductName,
                        SellPrice = s.SellPrice,
                        ProductUnit = s.ProductUnit,
                        CreditorCode = s.CreditorCode,
                        CreditorName = s.CreditorName,
                        BuyPrice = s.BuyPrice,
                        TransactionDate = s.TransactionDate,
                        TransactionDateStr = s.TransactionDate.ToString("dd/MMM/yy", Variable.culTH)
                    }).ToList();

                    var _cnt = tmpdataVSJob.GroupBy(g => new
                    {
                        g.DebtorCode, g.DebtorName
                    }).Select(s => new
                    {
                        s.Key.DebtorCode,
                        s.Key.DebtorName,
                        TransactionDate = s.Max(mx=>mx.TransactionDate),
                        CNT = s.Count()
                    }).ToList();

                    foreach (var itemC in _cnt.Where(w=>w.CNT < 35))
                    {
                        int _c = 35 -  itemC.CNT;
                        do
                        {
                            var _xx = new VSJOB();
                            _xx.iNo = 0;
                            _xx.BuyPrice = 0;
                            _xx.CreditorCode = "";
                            _xx.CreditorName = "";
                            _xx.DebtorCode = itemC.DebtorCode;
                            _xx.DebtorName = itemC.DebtorName;
                            _xx.JobCode = "";
                            _xx.JobID = 0;
                            _xx.JobName = "";
                            _xx.ProductCode = "";
                            _xx.ProductName = "";
                            _xx.ProductUnit = "";
                            _xx.SellPrice = 0;
                            _xx.TransactionDate = itemC.TransactionDate;
                            _xx.TransactionDateStr = "";
                            _xx.Reference = "z";
                            tmpdataVSJob.Add(_xx);
                            _c--; 
                        } while (_c > 0);
                    }
              

                    Reports.VS.rptVSBase rptVSBase = new VS.rptVSBase();
                    rptVSBase.xrFrom.Text = dtStart.ToString("dd MMM yyyy", Variable.culTH);
                    rptVSBase.xrTo.Text = dtEnd.ToString("dd MMM yyyy", Variable.culTH);
                    rptVSBase.DataSource = tmpdataVSJob;
                    documentViewer1.DocumentSource = rptVSBase;
                    rptVSBase.CreateDocument();
                    break;


                // Mill //

                case ReportType.MillVat:
                    var dataMillVat = db.vwrpt_TranCreditorMill.Where(w => w.TransactionDate >= dtStart
             && w.TransactionDate <= dtEnd && (w.ServiceIsVat.HasValue && w.ServiceIsVat.Value)).AsEnumerable().Select((s, inx) => new
             {
                 iNo = inx + 1,
                 TransactionDate = s.TransactionDate,
                 CreditorServiceID = s.CreditorServiceID,
                 CreditorServiceName = s.CreditorServiceName,
                 ServiceTotalAmount = s.ServiceTotalAmount,
                 ServiceVatAmount = s.ServiceVatAmount,
                 ServiceVatInt = s.ServiceVatInt,
                 ServiceNetAmount = s.ServiceNetAmount
             }).ToList();

                    Mills.rptMillVat rptMillVat = new Mills.rptMillVat();
                    rptMillVat.DataSource = dataMillVat;
                    documentViewer1.DocumentSource = rptMillVat;
                    rptMillVat.CreateDocument();
                    break;

                case ReportType.MillTran:

                    int _BP = -1; int _DR = -1;
                    if (this.keyId > 0)
                        _BP = this.keyId;
                    if (this.secondKeyId > 0)
                        _DR = this.secondKeyId;

                    var tmpDataMillTran = db.vwrpt_TransactionMill.ToList();

                    if (_BP > 0)
                        tmpDataMillTran = tmpDataMillTran.Where(w => w.DebitorPeriodID == _BP).ToList();

                    if (_DR > 0)
                        tmpDataMillTran = tmpDataMillTran.Where(w => w.CreditorServiceID == _DR).ToList();

                    var dataMillTran = tmpDataMillTran.Where(w => w.CreditorServiceID != null).OrderBy(o => o.CreditorServiceName)
                        .GroupBy(grp => new
                        {
                            DebitorName = grp.DebtorName,
                            DebitorCode = grp.DebtorCode,
                            ProductCode = grp.ProductCode,
                            ProductName = grp.ProductName,
                            ProductID = grp.ProductID,
                            CreditorServiceID = grp.CreditorServiceID,
                            CreditorServiceName = grp.CreditorServiceName,
                            CreditorServiceCode = grp.CreditorServiceCode,
                            DebitorPeriodID = grp.DebitorPeriodID,
                            DebitorPeriodCode = grp.DebitorPeriodCode,
                            TransactionDateCr = grp.TransactionDateCr,
                            DebitorDateFrom = grp.DebitorDateFrom,
                            DebitorDateTo = grp.DebitorDateTo
                        })
                        .AsEnumerable().Select((s, inx) => new
                        {
                            iNo = inx + 1,
                            DebitorName = s.Key.DebitorName,
                            DebitorCode = s.Key.DebitorCode,
                            ProductCode = s.Key.ProductCode,
                            ProductName = s.Key.ProductName,
                            ProductID = s.Key.ProductID,
                            CreditorServiceID = s.Key.CreditorServiceID,
                            CreditorServiceName = s.Key.CreditorServiceName,
                            CreditorServiceCode = s.Key.CreditorServiceCode,
                            DebitorPeriodID = s.Key.DebitorPeriodID,
                            DebitorPeriodCode = s.Key.DebitorPeriodCode,
                            TotalAmount = s.Sum(xx => xx.TotalAmount),
                            VatAmount = s.Sum(xx => xx.VatAmount),
                            VatInt = s.Sum(xx => xx.VatInt),
                            AtVatAmount = s.Sum(xx => xx.AtVatAmount),
                            AtVatInt = s.Sum(xx => xx.AtVatInt),
                            NetAmount = s.Sum(xx => xx.NetAmount),
                            TransactionDateCr = s.Key.TransactionDateCr,
                            TranWeight = s.Sum(xx => xx.TranWeight),
                            DebitorDateFrom = s.Key.DebitorDateFrom,
                            DebitorDateTo = s.Key.DebitorDateTo
                        }).ToList();

                    Mills.rptMilTran rptMilTran = new Mills.rptMilTran();
                    rptMilTran.DataSource = dataMillTran;
                    documentViewer1.DocumentSource = rptMilTran;
                    rptMilTran.CreateDocument();
                    break;

                case ReportType.MillConsolidate:

                    int _BPcd = -1; int _DRcd = -1;
                    if (this.keyId > 0)
                        _BPcd = this.keyId;
                    
                    var tmpDataMillCD = db.vwrpt_TransactionMill.ToList();

                    if (_BPcd > 0)
                        tmpDataMillCD = tmpDataMillCD.Where(w => w.JobID == _BPcd).ToList();

                    if (!(dtStart == DateTime.MinValue))
                        tmpDataMillCD = tmpDataMillCD.Where(w => w.JobDateStart >= dtStart).ToList();

                    if (!(dtEnd == DateTime.MinValue))
                        tmpDataMillCD = tmpDataMillCD.Where(w => w.JobDateStart <= dtEnd).ToList();

                    var seq = tmpDataMillCD.OrderBy(o => o.CreditorServiceName)
                     .Select((s, inx) => new
                        {
                            s.DebtorName,
                            DebitorCode = s.DebtorCode,
                            JobCode = s.JobCode,
                            JobName = s.JobName,

                            ProductCode = s.ProductCode,
                            ProductName = s.ProductName,
                            ProductID = s.ProductID,

                            CreditorID = s.CreditorID,
                            CreditorCode = s.CreditorCode,
                            CreditorName = s.CreditorName,

                            s.TranBuyPrice,
                            s.TranVatCr,

                            s.TranSellPrice,
                            s.TranVat,

                            CreditorServiceID = s.CreditorServiceID,
                            CreditorServiceName = s.CreditorServiceName,
                            CreditorServiceCode = s.CreditorServiceCode,
                            DebitorPeriodID = s.DebitorPeriodID,
                            DebitorPeriodCode = s.DebitorPeriodCode,
                            s.TotalAmountD,
                            s.VatAmount,
                            s.VatInt,

                            DebitorDateFrom = s.DebitorDateFrom,
                            DebitorDateTo = s.DebitorDateTo,

                            s.ProductServiceName,s.ProductServicePrice
                        }).Distinct().ToList();

                    var dataMillCD = seq.AsEnumerable()
                        .Select((s, inx) => new
                        {
                            iNo = inx + 1,
                            s.DebtorName,
                            s.DebitorCode,
                            JobCode = s.JobCode,
                            JobName = s.JobName,

                            ProductCode = s.ProductCode,
                            ProductName = s.ProductName,
                            ProductID = s.ProductID,

                            CreditorID = s.CreditorID,
                            CreditorCode = s.CreditorCode,
                            CreditorName = s.CreditorName,

                            s.TranBuyPrice,
                            s.TranVatCr,

                            s.TranSellPrice,
                            s.TranVat,

                            CreditorServiceID = s.CreditorServiceID,
                            CreditorServiceName = s.CreditorServiceName,
                            CreditorServiceCode = s.CreditorServiceCode,
                            DebitorPeriodID = s.DebitorPeriodID,
                            DebitorPeriodCode = s.DebitorPeriodCode,
                            s.TotalAmountD,
                            s.VatAmount,
                            s.VatInt,

                            DebitorDateFrom = s.DebitorDateFrom,
                            DebitorDateTo = s.DebitorDateTo,

                            s.ProductServiceName,
                            s.ProductServicePrice
                        }).ToList();

                    Mills.rptMillConsolidate rptMilCD = new Mills.rptMillConsolidate();
                    rptMilCD.DataSource = dataMillCD;
                    documentViewer1.DocumentSource = rptMilCD;
                    rptMilCD.CreateDocument();
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
            ,MillVat, MillTran, MillConsolidate
    }

    public class VSJOB
    {
        public int iNo { get; set; }
        public string DebtorCode { get; set; }
        public string DebtorName { get; set; }
        public int JobID { get; set; }
        public string JobCode { get; set; }
        public string JobName { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal SellPrice { get; set; }
        public string ProductUnit { get; set; }
        public string CreditorCode { get; set; }
        public string CreditorName { get; set; }
        public decimal BuyPrice { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionDateStr { get; set; }
        public string Reference { get; set; }
    }
}