using CS.BNP.App.Services;
using DevExpress.Export;
using DevExpress.XtraGrid.Views.Card;
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
    public partial class frmMillPrePaidCond : Form
    {
        public frmMillPrePaidCond()
        {
            InitializeComponent();
        }
        Entity.CSBNPEntities db = new Entity.CSBNPEntities();
        Services.GlobalService gloService = new Services.GlobalService();
        private void ClearForm()
        {
            BindingControl();
            this.cbDebitorPeriod.SelectedIndex = 0; this.cbMill.SelectedIndex = 0;
        }
        private void BindingControl()
        {
            var _tmpMill = db.mas_Creditor.ToList();
            var dataMill = _tmpMill.OrderBy(o => o.ID).Select(s => new
            {
                val = s.ID,
                txt = s.CreditorCode + " : " + s.CreditorName
            }).ToList();
            dataMill.Insert(0, new { val = 0, txt = "-- เลือกทั้งหมด --" });
            this. cbMill.DataSource = dataMill;
            this.cbMill.DisplayMember = "txt";
            this.cbMill.ValueMember = "val";

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
            int _BP = -1; int _DR = -1;
            if (this.cbDebitorPeriod.SelectedIndex > -1)
                _BP = int.Parse(this.cbDebitorPeriod.SelectedValue.ToString());
            if (this.cbMill.SelectedIndex > -1)
                _DR = int.Parse(this.cbMill.SelectedValue.ToString());

            var tmpData = db.vwrpt_TransactionMill.ToList();

            if (_BP > 0)
                tmpData = tmpData.Where(w => w.DebitorPeriodID == _BP).ToList();

            if (_DR > 0)
                tmpData = tmpData.Where(w => w.CreditorServiceID == _DR).ToList();

            var data = tmpData.Where(w=>w.CreditorServiceID != null).OrderBy(o=>o.CreditorServiceName)
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
             
            this.gridControl.DataSource = data;
            this.gridControl.ForceInitialize();
            
        }
        private void frmMillPrePaidCond_Load(object sender, EventArgs e)
        {
            //BuildDS();
            ClearForm();
            this.cbDebitorPeriod.Select();
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
                this.cbDebitorPeriod.Select(); return;
            }
            else
            {
                ReportViewer rptViewer = new ReportViewer();
                rptViewer.keyId = int.Parse(this.cbDebitorPeriod.SelectedValue.ToString()); //int.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns["BillingPeriodID"]).ToString());
                rptViewer.secondKeyId = int.Parse(this.cbMill.SelectedValue.ToString()); //int.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns["CreditorID"]).ToString());
                rptViewer.PrintReport(ReportType.MillTran);
                rptViewer.ShowDialog();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (this.gridView.RowCount == 0)
            {
                gloService.Announce("ไม่มีข้อมูลในการ Export .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                this.cbDebitorPeriod.Select(); return;
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
