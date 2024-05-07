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

namespace CS.BNP.App.Transaction
{
    public partial class frmBillngPeriod : Form
    {
        public frmBillngPeriod()
        {
            InitializeComponent();
        }
        Services.GlobalService gloService = new Services.GlobalService();
        private void frmBillngPeriod_Load(object sender, EventArgs e)
        {
            DGV();
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            frmAddEditBillingPeriod frm = new frmAddEditBillingPeriod();
            frm.BringToFront();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
        public void DGV()
        {
            using (var db = new Entity.CSBNPEntities())
            {
                var data = db.tran_BillingPeriod.AsEnumerable().Select((s,inx) => new
                {
                    iNo = inx +1,
                    ID = s.ID,
                    BillingPeriodCode = s.BillingPeriodCode,
                    BillingDateFrom = s.BillingDateFrom,
                    BillingDateTo = s.BillingDateTo,
                    BillingStatus = ((BillingPeriodStatus)s.BillingStatus).ToString()
                }).ToList();
                this.gridControl.DataSource = data;
                this.gridControl.ForceInitialize();

                //for (int i = 0; i < this.gridView.DataRowCount; i++)
                //{
                //    if (this.gridView.GetRowCellValue(i,"BillingPeriodStatus").ToString() == "Processed")
                //    {
                        
                //    }
                //}

            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmAddEditBillingPeriod frmEdit = new frmAddEditBillingPeriod();
            frmEdit.iType = int.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns[0]).ToString());
            frmEdit.BringToFront();
            frmEdit.StartPosition = FormStartPosition.CenterParent;
            frmEdit.ShowDialog();
            DGV();
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gloService.Sure("คุณต้องการลบข้อมูลรายการนี้ ?") == DialogResult.Yes)
            {
                int _deldata = int.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns[0]).ToString());
                using (var db = new Entity.CSBNPEntities())
                {
                    var del = db. tran_BillingPeriod.Where(w => w.ID == _deldata).FirstOrDefault();
                    db.tran_BillingPeriod.Remove(del);
                    db.SaveChanges();
                }
                DGV();
                gloService.Announce("ลบข้อมูลเรียบร้อย", AnnounceType.Infomation);
            }
            else return;
        }

        private void gridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "BillingStatus").ToString() == "Processed")
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = (gridView.FocusedColumn != this.gridView.Columns[6]) && (gridView.FocusedColumn != this.gridView.Columns[7]);
            }
        }
    }
}
