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
    public partial class frmCreditorViewer : Form
    {
        public frmCreditorViewer()
        {
            InitializeComponent();
        }
        Entity.CSBNPEntities db = new Entity.CSBNPEntities();
        Services.GlobalService gloService = new Services.GlobalService();
        private void ClearForm()
        {
            BindingControl();
            this.cbBillingPeriod.SelectedIndex = 0;
        }
        private void BindingControl()
        {
            var _tmp = db.tran_BillingPeriod.ToList();
            var data = _tmp.OrderBy(o => o.ID).Select(s => new
            {
                val = s.ID,
                txt = s.BillingPeriodCode + " : " + s.BillingDateFrom.ToString("dd.MM.yyyy", Variable.cul) + " - " + s.BillingDateTo.ToString("dd.MM.yyyy", Variable.cul)
            }).ToList();
            data.Insert(0, new { val = 0, txt = "-- เลือกช่วงเวลาการตั้งเบิกเจ้าหนี้ --" });
            this.cbBillingPeriod.DataSource = data;
            this.cbBillingPeriod.DisplayMember = "txt";
            this.cbBillingPeriod.ValueMember = "val";
        }
        public void DGV()
        {
            if (this.cbBillingPeriod.SelectedIndex > 0)
            {
                int _condition = int.Parse(this.cbBillingPeriod.SelectedValue.ToString());
                var data = db.tran_Creditor.Where(w => w.BillingPeriodID == _condition).AsEnumerable().Select((s, inx) => new
                {
                    iNo = inx + 1,
                    ID = s.ID,
                    BillingPeriodID = s.BillingPeriodID,
                    BillingPeriodCode = s.tran_BillingPeriod.BillingPeriodCode,
                    TransactionCreditorCode = s.TransactionCreditorCode,
                    TransactionDate = s.TransactionDate,
                    TransactionSeq = s.TransactionSeq,
                    DocumentNo = s.DocumentNo,
                    IsOutsidePeriod = s.IsOutsidePeriod,
                    CreditorID = s.CreditorID,
                    CreditorName = s.mas_Creditor.CreditorName,
                    JobID = s.JobID,
                    JobName = s.mas_Job.JobName,
                    ProductID = s.ProductID,
                    ProductName = s.mas_Product.ProductName,
                    ProductCode = s.mas_Product.ProductCode,
                    CarLicense = s.CarLicense,
                    Driver = s.Driver,
                    TranUnitQuantity = s.TranUnitQuantity,
                    TranWeight = s.TranWeight,
                    TranBuyPrice = s.TranBuyPrice,
                    TranDiscount = s.TranDiscount,
                    IsVat = s.IsVat,
                    TranVat = s.TranVat,
                    TotalAmount = s.TotalAmount,
                    IsPaid = s.IsPaid,
                    TranUnit = s.TranUnit
                }).ToList();
                this.gridControl.DataSource = data;
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
            this.btnReport.Visible = v; this.btnExport.Visible = v;
        }
        private void frmCreditorViewer_Load(object sender, EventArgs e)
        {
            ClearForm();
            this.cbBillingPeriod.Select();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
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
                rptViewer.keyId = int.Parse(this.cbBillingPeriod.SelectedValue.ToString());
                rptViewer.PrintReport(ReportType.SummaryCreditor);
                rptViewer.ShowDialog();
            }
        }

        private void cbBillingPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnReport.Visible = this.cbBillingPeriod.SelectedIndex > 0;
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
