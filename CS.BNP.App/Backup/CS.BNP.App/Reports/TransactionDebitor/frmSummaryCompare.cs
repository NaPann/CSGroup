using CS.BNP.App.Services;
using DevExpress.Export;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Views.Grid;
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

namespace CS.BNP.App.Reports.TransactionDebitor
{
    public partial class frmSummaryCompare : Form
    {
        public frmSummaryCompare()
        {
            InitializeComponent();
        }
        Entity.CSBNPEntities db = new Entity.CSBNPEntities();
        Services.GlobalService gloService = new Services.GlobalService();
        private void ClearForm()
        {
            BindingControl();
            this.cbDebitorPeriod.SelectedIndex = 0; this.cbDebitor.SelectedIndex = 0;
        }
        private void BindingControl()
        {
            var _tmpDebitor = db.mas_Debtor.ToList();
            var dataDebitor = _tmpDebitor.OrderBy(o => o.ID).Select(s => new
            {
                val = s.ID,
                txt = s.DebtorCode + " : " + s.DebtorName
            }).ToList();
            dataDebitor.Insert(0, new { val = 0, txt = "-- เลือกทั้งหมด --" });
            this.cbDebitor.DataSource = dataDebitor;
            this.cbDebitor.DisplayMember = "txt";
            this.cbDebitor.ValueMember = "val";

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
        private DataSet ds;
        private void BuildDS()
        {
            ds = new DataSet();
            ds.Tables.Add("TranDebitor"); ds.Tables.Add("TranDebitorDetail");
            ds.Tables[0].Columns.Add(new DataColumn("iNo", typeof(System.Int32)));
            ds.Tables[0].Columns.Add(new DataColumn("ID", typeof(System.Int32)));
            ds.Tables[0].Columns.Add(new DataColumn("DebitorPeriodID", typeof(System.Int32)));
            ds.Tables[0].Columns.Add(new DataColumn("DebitorPeriodCode", typeof(System.String)));
            ds.Tables[0].Columns.Add(new DataColumn("TransactionDebitorCode", typeof(System.String)));
            ds.Tables[0].Columns.Add(new DataColumn("TransactionDate", typeof(System.DateTime)));
            ds.Tables[0].Columns.Add(new DataColumn("TotalAmount", typeof(System.Decimal)));
            ds.Tables[0].Columns.Add(new DataColumn("IsReceived", typeof(System.Boolean)));
            ds.Tables[0].Columns.Add(new DataColumn("CheckedBy", typeof(System.String)));
            ds.Tables[0].Columns.Add(new DataColumn("CheckedDate", typeof(System.DateTime)));
            ds.Tables[0].Columns.Add(new DataColumn("DebitorName", typeof(System.String)));

            ds.Tables[1].Columns.Add(new DataColumn("MasterID", typeof(System.Int32)));
            ds.Tables[1].Columns.Add(new DataColumn("DetailID", typeof(System.Int32)));
            ds.Tables[1].Columns.Add(new DataColumn("JobID", typeof(System.Int32)));
            ds.Tables[1].Columns.Add(new DataColumn("JobName", typeof(System.String)));
            ds.Tables[1].Columns.Add(new DataColumn("ProductID", typeof(System.Int32)));
            ds.Tables[1].Columns.Add(new DataColumn("ProductName", typeof(System.String)));
            ds.Tables[1].Columns.Add(new DataColumn("CarLincense", typeof(System.String)));
            ds.Tables[1].Columns.Add(new DataColumn("DocumentNo", typeof(System.String)));
            ds.Tables[1].Columns.Add(new DataColumn("TranUnitQuantity", typeof(System.Int32)));
            ds.Tables[1].Columns.Add(new DataColumn("TranSellPrice", typeof(System.Decimal)));
            ds.Tables[1].Columns.Add(new DataColumn("TotalAmount", typeof(System.Int32)));
            ds.AcceptChanges();
        }
        public void DGV()
        {
            try
            {
                if (this.ds.Relations.Count > 0) this.ds.Relations.Remove("Details");
                this.ds.Tables[1].Rows.Clear();
                this.ds.Tables[0].Rows.Clear();
            }
            catch
            {
                gloService.Announce("Err : Clear Detail !", AnnounceType.Warning);
                this.cbDebitorPeriod.Select(); return;
            }
           
            int _BP = -1; int _DR = -1;
            if (this.cbDebitorPeriod.SelectedIndex > -1)
                _BP = int.Parse(this.cbDebitorPeriod.SelectedValue.ToString());
            if (this.cbDebitor.SelectedIndex > -1)
                _DR = int.Parse(this.cbDebitor.SelectedValue.ToString());

            var tmpData = db.tran_DebitorRec.ToList();

            if (_BP > 0)
                tmpData = tmpData.Where(w => w.DebitorPeriodID == _BP).ToList();

            if (_DR > 0)
                tmpData = tmpData.Where(w => w.DebitorID == _DR).ToList();

            foreach (var item in tmpData)
            {
                this.ds.Tables[0].Rows.Add(this.ds.Tables[0].Rows.Count + 1, item.ID, item.DebitorPeriodID, item.mas_DebitorBillingPeriod.DebitorPeriodCode,
                    item.TransactionDebitorCode,
                    item.TransactionDate,
                    item.TotalAmountByBill,
                    item.IsReceived, item.CheckedBy, item.CheckedDate, item.mas_Debtor.DebtorName);
                var dataDetail = db.tran_DebitorRecDetail.Where(w => w.MasterID == item.ID).ToList();
                foreach (var itemDetail in dataDetail)
                {
                    this.ds.Tables[1].Rows.Add(itemDetail.MasterID, itemDetail.ID,
                        itemDetail.tran_Creditor.JobID, itemDetail.tran_Creditor.mas_Job.JobName,
                        itemDetail.tran_Creditor.ProductID, itemDetail.tran_Creditor.mas_Product.ProductName,
                        itemDetail.tran_Creditor.CarLicense, itemDetail.tran_Creditor.DocumentNo,
                        itemDetail.tran_Creditor.TranUnitQuantity, itemDetail.TranSellPrice, itemDetail.TotalAmount);
                }
            }

            try
            {
                DataColumn keyColumn = this.ds.Tables[0].Columns["ID"];
                DataColumn foreignKeyColumn = this.ds.Tables[1].Columns["MasterID"];
                this.ds.Relations.Add("Details", keyColumn, foreignKeyColumn);
            }
            catch
            {
                //gloService.Announce("Err : Add Detail !", AnnounceType.Warning);
                //this.cbDebitorPeriod.Select(); return;
            }
            this.gridControl.DataSource = this.ds.Tables[0];
            this.gridControl.ForceInitialize();

            //Assign a CardView to the relationship 
            CardView cardView1 = new CardView(gridControl);
            gridControl.LevelTree.Nodes.Add("Details", cardView1);
            //Specify text to be displayed within detail tabs. 
            cardView1.ViewCaption = "รายละเอียดการวางบิลลูกหนี้";

            //Hide the CategoryID column for the master View 
            gridView.Columns["ID"].VisibleIndex = -1; gridView.Columns["DebitorPeriodID"].VisibleIndex = -1;

            //Create columns for the detail pattern View 
            cardView1.PopulateColumns(this.ds.Tables["TranDebitorDetail"]);
            //Hide the CategoryID column for the detail View 
            cardView1.Columns["JobID"].VisibleIndex = -1;
            cardView1.Columns["DetailID"].VisibleIndex = -1;
            cardView1.Columns["ProductID"].VisibleIndex = -1; cardView1.Columns["MasterID"].VisibleIndex = -1;
            //Format UnitPrice column values as currency 
            cardView1.Columns["TranUnitQuantity"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            cardView1.Columns["TranUnitQuantity"].DisplayFormat.FormatString = "N0";
            cardView1.Columns["TranUnitQuantity"].Caption = "จำนวนคิว";

            cardView1.Columns["TranSellPrice"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            cardView1.Columns["TranSellPrice"].DisplayFormat.FormatString = "N2";
            cardView1.Columns["TranSellPrice"].Caption = "ราคาขาย";

            cardView1.Columns["TotalAmount"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            cardView1.Columns["TotalAmount"].DisplayFormat.FormatString = "N2";
            cardView1.Columns["TotalAmount"].Caption = "ราคารวม";

            cardView1.Columns["JobName"].Caption = "ชื่องาน";
            cardView1.Columns["ProductName"].Caption = "ชื่อสินค้า";

            cardView1.Columns["CarLincense"].Caption = "ทะเบียนรถ";
            cardView1.Columns["DocumentNo"].Caption = "เลขที่";
        }
        private void frmSummaryCompare_Load(object sender, EventArgs e)
        {
            BuildDS();
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
                rptViewer.secondKeyId = int.Parse(this.cbDebitor.SelectedValue.ToString()); //int.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns["CreditorID"]).ToString());
                rptViewer.PrintReport(ReportType.ReportDebitor);
                rptViewer.ShowDialog();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
