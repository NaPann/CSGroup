using CS.BNP.App.Services;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS.BNP.App.EmployeeSecurity
{
    public partial class frmViewApproval : Form
    {
        public frmViewApproval()
        {
            InitializeComponent();
        }
        Services.GlobalService gloService = new Services.GlobalService();
        private DataSet ds;
        public void DGV()
        {
            ds = new DataSet();
            ds.Tables.Add("Job"); ds.Tables.Add("JobDetail"); ds.Tables.Add("JobCreditor");
            ds.Tables[0].Columns.Add(new DataColumn("ID", typeof(System.Int32)));
            ds.Tables[0].Columns.Add(new DataColumn("JobCode", typeof(System.String)));
            ds.Tables[0].Columns.Add(new DataColumn("JobDateStart", typeof(System.DateTime)));
            ds.Tables[0].Columns.Add(new DataColumn("JobName", typeof(System.String)));
            ds.Tables[0].Columns.Add(new DataColumn("Budget", typeof(System.Decimal)));
            ds.Tables[0].Columns.Add(new DataColumn("DebtorName", typeof(System.String)));
            ds.Tables[0].Columns.Add(new DataColumn("DebtorCode", typeof(System.String)));
            ds.Tables[0].Columns.Add(new DataColumn("DebtorID", typeof(System.Int32)));
            //ds.Tables[0].Columns.Add(new DataColumn("IsApprove", typeof(System.Boolean)));

            ds.Tables[1].Columns.Add(new DataColumn("JobID", typeof(System.Int32)));
            ds.Tables[1].Columns.Add(new DataColumn("DetailID", typeof(System.Int32)));
            ds.Tables[1].Columns.Add(new DataColumn("ProductID", typeof(System.Int32)));
            ds.Tables[1].Columns.Add(new DataColumn("ProductCode", typeof(System.String)));
            ds.Tables[1].Columns.Add(new DataColumn("ProductName", typeof(System.String)));
            ds.Tables[1].Columns.Add(new DataColumn("JobQuantity", typeof(System.Decimal)));
            ds.Tables[1].Columns.Add(new DataColumn("ProductPriceExactly", typeof(System.Decimal)));
            ds.AcceptChanges();

            ds.Tables[2].Columns.Add(new DataColumn("JobID", typeof(System.Int32)));
            ds.Tables[2].Columns.Add(new DataColumn("DetailID", typeof(System.Int32)));
            ds.Tables[2].Columns.Add(new DataColumn("CreditorID", typeof(System.Int32)));
            ds.Tables[2].Columns.Add(new DataColumn("CreditorName", typeof(System.String)));
            ds.Tables[2].Columns.Add(new DataColumn("ProductID", typeof(System.Int32)));
            ds.Tables[2].Columns.Add(new DataColumn("ProductCode", typeof(System.String)));
            ds.Tables[2].Columns.Add(new DataColumn("ProductName", typeof(System.String)));
            ds.Tables[2].Columns.Add(new DataColumn("ProductSell", typeof(System.Decimal)));
            ds.Tables[2].Columns.Add(new DataColumn("SourceFrom", typeof(System.String)));
            ds.AcceptChanges();

            using (var db = new Entity.CSBNPEntities())
            {
                //db.Configuration.LazyLoadingEnabled = false;
                //find information for approve
                string[] _find = db.sec_EmployeeUser.Where(w => w.NeedToApproveBy == Variable.CurrentProfile.username).Select(s => s.Username).ToArray();
                var data = db.mas_Job.Where(w => _find.Contains(w.UpdatedBy) && !w.IsApprove).ToList();
                foreach (var item in data)
                {
                    this.ds.Tables[0].Rows.Add(item.ID, item.JobCode, item.JobDateStart, item.JobName,
                        item.Budget, item.mas_Debtor.DebtorName, item.mas_Debtor.DebtorCode, item.DebtorID);
                    var dataDetail = db.mas_JobDetail.Where(w => w.JobID == item.ID).ToList();
                    foreach (var itemDetail in dataDetail)
                    {
                        this.ds.Tables[1].Rows.Add(itemDetail.JobID, itemDetail.ID,
                            itemDetail.ProductID, itemDetail.mas_Product.ProductCode, itemDetail.mas_Product.ProductName,
                            itemDetail.JobQuantity, itemDetail.ProductPriceExactly);
                    }
                    var dataCreditor = db.mas_JobCreditor.Where(w => w.JobID == item.ID).ToList();
                    foreach (var itemDetail in dataCreditor)
                    {
                        this.ds.Tables[2].Rows.Add(itemDetail.JobID, itemDetail.ID, itemDetail.CreditorID, itemDetail.mas_Creditor.CreditorName,
                            itemDetail.ProductID, itemDetail.mas_Product.ProductCode, itemDetail.mas_Product.ProductName,
                            itemDetail.ProductSellPrice, itemDetail.SourceFrom);
                    }
                }
                DataColumn keyColumn = this.ds.Tables[0].Columns["ID"];
                DataColumn foreignKeyColumn = this.ds.Tables[1].Columns["JobID"];
                this.ds.Relations.Add("Products", keyColumn, foreignKeyColumn);
                DataColumn foreignKeyColumnCre = this.ds.Tables[2].Columns["JobID"];
                this.ds.Relations.Add("Creditors", keyColumn, foreignKeyColumnCre);

                this.gridControl.DataSource = this.ds.Tables[0];
                this.gridControl.ForceInitialize();

                //Assign a CardView to the relationship 
                CardView cardView1 = new CardView(gridControl);
                gridControl.LevelTree.Nodes.Add("Products", cardView1);
                //Specify text to be displayed within detail tabs. 
                cardView1.ViewCaption = "สินค้าที่อยู่ในโปรเจค";

                //Hide the CategoryID column for the master View 
                gridView1.Columns["ID"].VisibleIndex = -1;
                //Create columns for the detail pattern View 
                cardView1.PopulateColumns(this.ds.Tables["JobDetail"]);
                //Hide the CategoryID column for the detail View 
                cardView1.Columns["JobID"].VisibleIndex = -1; cardView1.Columns["DetailID"].VisibleIndex = -1; cardView1.Columns["ProductID"].VisibleIndex = -1;
                //Format UnitPrice column values as currency 
                cardView1.Columns["ProductPriceExactly"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                cardView1.Columns["ProductPriceExactly"].DisplayFormat.FormatString = "N2";
                cardView1.Columns["ProductPriceExactly"].Caption = "ราคาสินค้า";

                cardView1.Columns["JobQuantity"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                cardView1.Columns["JobQuantity"].DisplayFormat.FormatString = "N2";
                cardView1.Columns["JobQuantity"].Caption = "จำนวน"; cardView1.Columns["ProductCode"].Caption = "รหัสสินค้า";
                cardView1.Columns["ProductName"].Caption = "ชื่อสินค้า";

                //Assign a CardView to the relationship =================================== Creditor
                CardView cardView2 = new CardView(gridControl);
                gridControl.LevelTree.Nodes.Add("Creditors", cardView2);
                //Specify text to be displayed within detail tabs. 
                cardView2.ViewCaption = "ราคาซื้อสินค้าจากเจ้าหนี้";

                //Hide the CategoryID column for the master View 
                gridView1.Columns["ID"].VisibleIndex = -1;
                //Create columns for the detail pattern View 
                cardView2.PopulateColumns(this.ds.Tables["JobCreditor"]);
                //Hide the CategoryID column for the detail View 
                cardView2.Columns["JobID"].VisibleIndex = -1; cardView2.Columns["DetailID"].VisibleIndex = -1; cardView2.Columns["ProductID"].VisibleIndex = -1; cardView2.Columns["CreditorID"].VisibleIndex = -1;
                //Format UnitPrice column values as currency 
                cardView2.Columns["ProductSell"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                cardView2.Columns["ProductSell"].DisplayFormat.FormatString = "N2";
                cardView2.Columns["ProductSell"].Caption = "ราคาสินค้า";

                cardView2.Columns["ProductCode"].Caption = "รหัสสินค้า";
                cardView2.Columns["ProductName"].Caption = "ชื่อสินค้า";
                cardView2.Columns["CreditorName"].Caption = "ชื่อเจ้าหนี้";
                cardView2.Columns["SourceFrom"].Caption = "แหล่งวัสดุ";

                this.btnApproveAll.Visible = this.gridView1.RowCount > 0;
                ExpandAllRows(this.gridView1);
            }
        }

        public void ExpandAllRows(GridView View)
        {
            View.BeginUpdate();
            try
            {
                int dataRowCount = View.DataRowCount;
                for (int rHandle = 0; rHandle < dataRowCount; rHandle++)
                    View.SetMasterRowExpanded(rHandle, true);
            }
            finally
            {
                View.EndUpdate();
            }
        }

        private void btnApp_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gloService.Sure("คุณต้องการอนุมัติข้อมูลโครงการนี้ ?") == DialogResult.Yes)
            {
                int _keydata = int.Parse(this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString());
                using (var db = new Entity.CSBNPEntities())
                {
                    var appr = db.mas_Job.Where(w => w.ID == _keydata).FirstOrDefault();
                    appr.IsApprove = true;
                    db.SaveChanges();
                }
                DGV();
            }
            else return;
        }

        private void frmViewApproval_Load(object sender, EventArgs e)
        {
            DGV();
        }

        private void btnApproveAll_Click(object sender, EventArgs e)
        {
            if (gloService.Sure("คุณต้องการอนุมัติข้อมูลโครงการทั้งหมด ?") == DialogResult.Yes)
            {
                using (var db = new Entity.CSBNPEntities())
                {
                    db.Configuration.LazyLoadingEnabled = false;
                    //find information for approve
                    string[] _find = db.sec_EmployeeUser.Where(w => w.NeedToApproveBy == Variable.CurrentProfile.username).Select(s => s.Username).ToArray();
                    var data = db.mas_Job.Where(w => _find.Contains(w.CreatedBy) && !w.IsApprove).ToList();

                    data.ForEach(w => w.IsApprove = true);
                    db.SaveChanges();
                }
                DGV();
            }
            else return;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
