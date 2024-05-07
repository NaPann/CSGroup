using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS.BNP.App.Transaction.Creditor
{
    public partial class frmViewCreditorMillPrePaid : Form
    {
        public frmViewCreditorMillPrePaid()
        {
            InitializeComponent();
        }
        Entity.CSBNPEntities db = new Entity.CSBNPEntities();
        Services.GlobalService gloService = new Services.GlobalService();
        public void DGV()
        {
            db = new Entity.CSBNPEntities();
            var data = db.tran_CreditorMillPrePaid.AsEnumerable().Select((s, inx) => new
            {
                iNo = inx + 1,
                ID = s.ID,
                CreditorID = s.CreditorServiceID,
                CreditorName = s.mas_Creditor.CreditorName,
                JobID = s.JobID,
                JobName = s.mas_Job.JobName,
                TotalAmount = s.TotalAmount,
                Diff = s.TotalAmount - s.PaidAmount,
            }).ToList();
            this.gridControl.DataSource = data;
            this.gridControl.ForceInitialize();
        }
      
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            frmAddEditCreditorMillPrePaid frm = new frmAddEditCreditorMillPrePaid();
            frm.BringToFront();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddEditCreditorMillPrePaid frmEdit = new frmAddEditCreditorMillPrePaid();
            frmEdit.iType = int.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns[0]).ToString());
            frmEdit.BringToFront();
            frmEdit.StartPosition = FormStartPosition.CenterParent;
            frmEdit.ShowDialog();
            DGV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gloService.Sure("คุณต้องการลบข้อมูลรายการนี้ ?") == DialogResult.Yes)
            {
                int _deldata = int.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns[0]).ToString());
                using (var db = new Entity.CSBNPEntities())
                {
                    var del = db.tran_CreditorMillPrePaid.Where(w => w.ID == _deldata).FirstOrDefault();
                    db.tran_CreditorMillPrePaid.Remove(del);
                    db.SaveChanges();
                }
                DGV();
                //gloService.Announce("ลบข้อมูลเรียบร้อย", AnnounceType.Infomation);
            }
            else return;
        }

        private void frmViewCreditorMillPrePaid_Load(object sender, EventArgs e)
        {
            DGV();
        }
    }
}
