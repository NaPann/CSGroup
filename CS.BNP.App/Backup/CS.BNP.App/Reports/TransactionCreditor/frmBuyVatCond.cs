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
    public partial class frmBuyVatCond : Form
    {
        public frmBuyVatCond()
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
        private void frmBuyVatCond_Load(object sender, EventArgs e)
        {
            this.dtpMonth.Select();            
            DGV();
            this.btnReport.Visible = this.gridView.RowCount > 0;
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            if (this.gridView.RowCount == 0)
            {
                gloService.Announce("ไม่มีข้อมูลในการออกรายงาน .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                this.dtpMonth.Select(); return;
            }
            else
            {
                ReportViewer rptViewer = new ReportViewer();
                rptViewer.dtStart = DTStart;
                rptViewer.dtEnd = DTEnd;
                rptViewer.PrintReport(ReportType.BuyVat);
                rptViewer.ShowDialog();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpMonth_ValueChanged(object sender, EventArgs e)
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
