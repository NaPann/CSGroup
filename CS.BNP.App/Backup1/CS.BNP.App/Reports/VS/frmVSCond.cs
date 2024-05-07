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

namespace CS.BNP.App.Reports.VS
{
    public partial class frmVSCond : Form
    {
        public frmVSCond()
        {
            InitializeComponent();
        }
        Entity.CSBNPEntities db = new Entity.CSBNPEntities();
        Services.GlobalService gloService = new Services.GlobalService();
        private DateTime DTStart; private DateTime DTEnd;
        private void ClearForm()
        {
            this.dtpFrom.Value = DateTime.Now; this.dtpTo.Value = DateTime.Now;
        }
        public void DGV()
        {
            DateTime _dateStart = new DateTime(this.dtpFrom.Value.Year, this.dtpFrom.Value.Month, this.dtpFrom.Value.Day);
            DateTime _dateEnd = new DateTime(this.dtpTo.Value.Year, this.dtpTo.Value.Month, this.dtpTo.Value.Day);

            var tmpdata = db.vwrpt_VersusBuySell.Where(w => w.SellDate >= _dateStart
      && w.SellDate <= _dateEnd).OrderBy(o => o.SellDate).Select(s => new
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

            var tmpdataVS = tmpdata.OrderBy(o=>o.SellDate).ThenBy(t=>t.JobName).ThenBy(t=>t.ProductName).AsEnumerable().Select((s, inx) => new
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

            this.gridControl.DataSource = tmpdataVS;
            this.gridControl.ForceInitialize();

            DTStart = _dateStart; DTEnd = _dateEnd;

            ControlBTN(this.gridView.RowCount > 0);
        }
        private void ControlBTN(bool v)
        {
            this.btnReport.Visible = v; this.btnExport.Visible = v;
        }
        private void frmVSCond_Load(object sender, EventArgs e)
        {
            this.dtpFrom.Select();
            DGV();
            this.btnReport.Visible = this.gridView.RowCount > 0;
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
                this.dtpFrom.Select(); return;
            }
            else
            {
                ReportViewer rptViewer = new ReportViewer();
                rptViewer.dtStart = DTStart;
                rptViewer.dtEnd = DTEnd;
                rptViewer.PrintReport(ReportType.VS);
                rptViewer.ShowDialog();
            }
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
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
