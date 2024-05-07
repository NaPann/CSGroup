using DevExpress.XtraGrid.Views.Card;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS.BNP.App.SystemSetup.Job
{
    public partial class frmViewJob : Form
    {
        public frmViewJob()
        {
            InitializeComponent();
        }
        Services.GlobalService gloService = new Services.GlobalService();
        private void btnAddData_Click(object sender, EventArgs e)
        {
            frmAddEditJob frm = new frmAddEditJob();
            frm.BringToFront();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
        private DataSet ds;
        public void DGV()
        {
            ds = new DataSet();
            ds.Tables.Add("Job"); ds.Tables.Add("JobDetail");
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
            ds.Tables[1].Columns.Add(new DataColumn("ProductPriceExactly", typeof(System.Int32)));
            ds.AcceptChanges();

            using (var db = new Entity.CSBNPEntities())
            {
                var data = db.mas_Job.ToList();
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
                }
                DataColumn keyColumn = this.ds.Tables[0].Columns["ID"];
                DataColumn foreignKeyColumn = this.ds.Tables[1].Columns["JobID"];
                this.ds.Relations.Add("Products", keyColumn, foreignKeyColumn);


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
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmAddEditJob frmEdit = new frmAddEditJob();
            frmEdit.iType = int.Parse(this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString());
            frmEdit.BringToFront();
            frmEdit.StartPosition = FormStartPosition.CenterParent;
            frmEdit.ShowDialog();
            DGV();
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gloService.Sure("คุณต้องการลบข้อมูลรายการนี้ ?") == DialogResult.Yes)
            {
                int _deldata = int.Parse(this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString());
                using (var db = new Entity.CSBNPEntities())
                {
                    var delDetail = db.mas_JobDetail.Where(w => w.JobID == _deldata).ToList();
                    db.mas_JobDetail.RemoveRange(delDetail);
                    var del = db.mas_Job.Where(w => w.ID == _deldata).FirstOrDefault();
                    db.mas_Job.Remove(del);
                    db.SaveChanges();
                }
                DGV();
                //gloService.Announce("ลบข้อมูลเรียบร้อย", AnnounceType.Infomation);
            }
            else return;
        }

        private void frmViewJob_Load(object sender, EventArgs e)
        {
            DGV();
        }

        private void btnAddCreditor_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmAddEditJobCreditor frmEdit = new frmAddEditJobCreditor();
            frmEdit.jobId = int.Parse(this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString());
            frmEdit.BringToFront();
            frmEdit.StartPosition = FormStartPosition.CenterParent;
            frmEdit.ShowDialog();
            DGV();
        }
    }
}
