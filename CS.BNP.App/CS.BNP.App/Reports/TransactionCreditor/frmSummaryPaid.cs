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

namespace CS.BNP.App.Reports.TransactionCreditor
{
    public partial class frmSummaryPaid : Form
    {
        public frmSummaryPaid()
        {
            InitializeComponent();
        }
        Entity.CSBNPEntities db = new Entity.CSBNPEntities();
        Services.GlobalService gloService = new Services.GlobalService();
        private void ClearForm()
        {
            BindingControl();
            this.cbBillingPeriod.SelectedIndex = 0; this.cbCreditor.SelectedIndex = 0;
        }
        private void BindingControl()
        {
            var _tmpCreditor = db.mas_Creditor.ToList();
            var dataCreditor = _tmpCreditor.OrderBy(o => o.ID).Select(s => new
            {
                val = s.ID,
                txt = s.CreditorCode + " : " + s.CreditorName
            }).ToList();
            dataCreditor.Insert(0, new { val = 0, txt = "-- เลือกทั้งหมด --" });
            this.cbCreditor.DataSource = dataCreditor;
            this.cbCreditor.DisplayMember = "txt";
            this.cbCreditor.ValueMember = "val";

            var _tmp = db.tran_BillingPeriod.ToList();
            var data = _tmp.OrderBy(o => o.ID).Select(s => new
            {
                val = s.ID,
                txt = s.BillingPeriodCode + " : " + s.BillingDateFrom.ToString("dd.MM.yyyy", Variable.cul) + " - " + s.BillingDateTo.ToString("dd.MM.yyyy", Variable.cul)
            }).ToList();
            data.Insert(0, new { val = 0, txt = "-- เลือกช่วงเวลาการตั้งเบิกจ่าย --" });
            this.cbBillingPeriod.DataSource = data;
            this.cbBillingPeriod.DisplayMember = "txt";
            this.cbBillingPeriod.ValueMember = "val";
        }
        public void DGV()
        {
            int _BP = -1; int _CR = -1;
            if (this.cbBillingPeriod.SelectedIndex > -1)
             _BP = int.Parse(this.cbBillingPeriod.SelectedValue.ToString());
            if (this.cbCreditor.SelectedIndex > -1)
                _CR = int.Parse(this.cbCreditor.SelectedValue.ToString());

            var tmpData = db.vwrpt_SumTransactionCreditor.ToList();

            if (_BP > 0)
                tmpData = tmpData.Where(w => w.BillingPeriodID == _BP).ToList();

            if (_CR > 0)
                tmpData = tmpData.Where(w => w.CreditorID == _CR).ToList();

            var data = tmpData.AsEnumerable().Select((s, inx) => new
            {
                iNo = inx + 1,
                BillingPeriodID = s.BillingPeriodID,
                BillingPeriodCode = s.BillingPeriodCode,
                TranUnitQuantity = s.TranUnitQuantity,
                CreditorID = s.CreditorID,
                JobID = s.JobID,
                JobName = s.JobName,
                ProductID = s.ProductID,
                ProductName = s.ProductName,
                ProductCode = s.ProductCode,
                TranWeight = s.TranWeight,
                TranBuyPrice = s.TranBuyPrice,
                TranDiscount = s.TranDiscount,
                TranVat = s.TranVat,
                TotalAmount = s.TotalAmount,
                CreditorName = s.CreditorName,
                TranUnit = s.TranUnit
            }).ToList();
            this.gridControl.DataSource = data;
            this.gridControl.ForceInitialize();
            this.btnExport.Visible = this.gridView.RowCount > 0;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (this.gridView.RowCount == 0)
            {
                gloService.Announce("ไม่มีข้อมูลในการออกรายงาน .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                this.cbBillingPeriod.Select(); return;
            }
            else
            {
                ReportViewer rptViewer = new ReportViewer();
                rptViewer.keyId = int.Parse(this.cbBillingPeriod.SelectedValue.ToString()); //int.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns["BillingPeriodID"]).ToString());
                rptViewer.secondKeyId = int.Parse(this.cbCreditor.SelectedValue.ToString()); //int.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns["CreditorID"]).ToString());
                rptViewer.PrintReport(ReportType.ReportCreditor);
                rptViewer.ShowDialog();
            }
        }
        private void frmSummaryPaid_Load(object sender, EventArgs e)
        {
            ClearForm();
            this.cbBillingPeriod.Select();
        }

        private void cbCreditor_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void cbBillingPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            DGV();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
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
    }
}
