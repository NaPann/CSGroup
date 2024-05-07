using CS.BNP.App.Services;
using DevExpress.Export;
using DevExpress.XtraPrinting;
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
    public partial class frmMillConsolidate : Form
    {
        public frmMillConsolidate()
        {
            InitializeComponent();
        }
        Entity.CSBNPEntities db = new Entity.CSBNPEntities();
        Services.GlobalService gloService = new Services.GlobalService();
        private void frmMillConsolidate_Load(object sender, EventArgs e)
        {
            ClearForm();
            this.cbJob.Select();
        }
        private void ClearForm()
        {
            BindingControl();
            this.cbJob.SelectedIndex = 0;
        }
        private void BindingControl()
        {
            var _tmpMill = db.mas_Job.ToList();
            var dataMill = _tmpMill.OrderBy(o => o.ID).Select(s => new
            {
                val = s.ID,
                txt = s.JobCode + " : " + s.JobName
            }).ToList();
            dataMill.Insert(0, new { val = 0, txt = "-- เลือกทั้งหมด --" });
            this.cbJob.DataSource = dataMill;
            this.cbJob.DisplayMember = "txt";
            this.cbJob.ValueMember = "val";

            //var _tmp = db.mas_DebitorBillingPeriod.ToList();
            //var data = _tmp.OrderBy(o => o.ID).Select(s => new
            //{
            //    val = s.ID,
            //    txt = s.DebitorPeriodCode + " : " + s.DebitorDateFrom.ToString("dd.MM.yyyy", Variable.cul) + " - " + s.DebitorDateTo.ToString("dd.MM.yyyy", Variable.cul)
            //}).ToList();
            //data.Insert(0, new { val = 0, txt = "-- เลือกช่วงเวลาการตั้งเบิกลูกหนี้ --" });
            //this.cbDebitorPeriod.DataSource = data;
            //this.cbDebitorPeriod.DisplayMember = "txt";
            //this.cbDebitorPeriod.ValueMember = "val";
        }
        public void DGV()
        {
            DateTime _dateStart = new DateTime(); DateTime _dateEnd = new DateTime();
            if (dtpMonthFrom.Checked)
                _dateStart = new DateTime(this.dtpMonthFrom.Value.Year, this.dtpMonthFrom.Value.Month, 1);

            if (this.dtpMonthTo.Checked)
            {
                _dateEnd = new DateTime(this.dtpMonthTo.Value.Year, this.dtpMonthTo.Value.Month, 1);
                _dateEnd = _dateEnd.AddMonths(1).AddDays(-1);
            }

            int _JR = -1;
            if (this.cbJob.SelectedIndex > -1)
                _JR = int.Parse(this.cbJob.SelectedValue.ToString());

            var tmpData = db.vwrpt_TransactionMill.ToList();

            if (_JR > 0)
                tmpData = tmpData.Where(w => w.JobID == _JR).ToList();

            if (this.dtpMonthFrom.Checked)
            {
                tmpData = tmpData.Where(w => w.JobDateStart.HasValue && w.JobDateStart.Value >= _dateStart).ToList();
            }

            if (this.dtpMonthTo.Checked)
            {
                tmpData = tmpData.Where(w => w.JobDateStart.HasValue && w.JobDateStart.Value <= _dateEnd).ToList();
            }

            var seq = tmpData.OrderBy(o => o.CreditorServiceName)
                .Select((s, inx) => new
                {
                    DebitorName = s.DebtorName,
                    DebitorCode = s.DebtorCode,
                    JobCode = s.JobCode,
                    JobName = s.JobName,

                    ProductCode = s.ProductCode,
                    ProductName = s.ProductName,
                    ProductID = s.ProductID,

                    CreditorID = s.CreditorID,
                    CreditorCode = s.CreditorCode,
                    CreditorName = s.CreditorName,

                    ProductSellPrice = s.TranBuyPrice,
                    ProductBuyPrice = s.TranSellPrice,

                    SellVat = s.TranVatCr,

                    BuyVat = s.TranVat,

                    CreditorServicelID = s.CreditorServiceID,
                    CreditorMillName = s.CreditorServiceName,
                    CreditorMillCode = s.CreditorServiceCode,
                    DebitorPeriodID = s.DebitorPeriodID,
                    DebitorPeriodCode = s.DebitorPeriodCode,

                    CreditorServiceName = s.CreditorServiceName,
                    DebitorDateFrom = s.DebitorDateFrom,
                    DebitorDateTo = s.DebitorDateTo,
                    s.VatAmount,
                    s.VatInt,
                    s.ProductServiceName,
                    s.ProductServicePrice

                }).Distinct().ToList();

            var data = seq.AsEnumerable().Select((s, inx) => new
            {
                iNo = inx + 1,
                DebitorName = s.DebitorName,
                DebitorCode = s.DebitorCode,
                JobCode = s.JobCode,
                JobName = s.JobName,

                ProductCode = s.ProductCode,
                ProductName = s.ProductName,
                ProductID = s.ProductID,

                CreditorID = s.CreditorID,
                CreditorCode = s.CreditorCode,
                CreditorName = s.CreditorName,

                s.ProductSellPrice,
                s.ProductBuyPrice,
                s.VatAmount,
                s.VatInt,
                s.CreditorServicelID,
                CreditorMillName = s.CreditorServiceName,
                s.CreditorMillCode,
                DebitorPeriodID = s.DebitorPeriodID,
                DebitorPeriodCode = s.DebitorPeriodCode,

                CreditorServiceName = s.CreditorServiceName,
                DebitorDateFrom = s.DebitorDateFrom,
                DebitorDateTo = s.DebitorDateTo,

                s.SellVat,

                s.BuyVat,

                s.ProductServiceName,
                s.ProductServicePrice
            }).ToList();



            this.gridControl.DataSource = data;
            this.gridControl.ForceInitialize();
            this.gridView.BestFitColumns();

        }
    
        private void btnLoad_Click(object sender, EventArgs e)
        {
            DGV();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (this.gridView.RowCount == 0)
            {
                gloService.Announce("ไม่มีข้อมูลในการออกรายงาน .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                this.cbJob.Select(); return;
            }
            else
            {
                ReportViewer rptViewer = new ReportViewer();
                rptViewer.keyId = int.Parse(this.cbJob.SelectedValue.ToString());
                DateTime _dateStart = new DateTime(); DateTime _dateEnd = new DateTime();
                if (dtpMonthFrom.Checked)
                {
                    _dateStart = new DateTime(this.dtpMonthFrom.Value.Year, this.dtpMonthFrom.Value.Month, 1);
                    rptViewer.dtStart = _dateStart;
                }
                if (this.dtpMonthTo.Checked)
                {
                    _dateEnd = new DateTime(this.dtpMonthTo.Value.Year, this.dtpMonthTo.Value.Month, 1);
                    _dateEnd = _dateEnd.AddMonths(1).AddDays(-1);
                    rptViewer.dtEnd = _dateEnd;
                }
                rptViewer.PrintReport(ReportType.MillConsolidate);
                rptViewer.ShowDialog();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (this.gridView.RowCount == 0)
            {
                gloService.Announce("ไม่มีข้อมูลในการ Export .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                this.cbJob.Select(); return;
            }

            ExportExcel("ExcelData");
        }
        private bool ExportExcel(string filename)
        {
            try
            {
                if (this.gridView.FocusedRowHandle < 0)
                {

                }
                else
                {
                    var dialog = new SaveFileDialog();
                    dialog.Title = @"Export file excel";
                    dialog.FileName = filename;
                    dialog.Filter = @"Excel Workbook|*.xlsx";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        gridView.ColumnPanelRowHeight = 40;
                        gridView.OptionsPrint.AutoWidth = AutoSize;
                        gridView.OptionsPrint.ShowPrintExportProgress = true;
                        gridView.OptionsPrint.AllowCancelPrintExport = true;
                        XlsxExportOptions options = new XlsxExportOptions();
                        options.TextExportMode = TextExportMode.Text;
                        options.ExportMode = XlsxExportMode.SingleFile;
                        options.SheetName = @"sheet1";

                        ExportSettings.DefaultExportType = ExportType.Default;
                        gridView.ExportToXlsx(dialog.FileName, options);
                        gloService.Announce("Export to Excel เรียบร้อย !!", AnnounceType.Infomation);
                    }
                }

            }
            catch (Exception e)
            {
                gloService.Announce("Export Error : " + e.Message, AnnounceType.Warning);
            }
            return false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
