using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS.BNP.App.SystemSetup.StoneMill
{
    public partial class frnViewCreditorMill : Form
    {
        public frnViewCreditorMill()
        {
            InitializeComponent();
        }
        Services.GlobalService gloService = new Services.GlobalService();
        private void frnViewStoneMill_Load(object sender, EventArgs e)
        {
            DGV();
        }
        public void DGV()
        {
            using (var db = new Entity.CSBNPEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                var data = db.mas_CreditorMill.ToList();
                this.gridControl.DataSource = data;
                this.gridControl.RefreshDataSource();
            }
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            frmAddEditCreditorMill frm = new frmAddEditCreditorMill();
            frm.BringToFront();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmAddEditCreditorMill frmEdit = new frmAddEditCreditorMill();
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
                    var del = db.mas_CreditorMill.Where(w => w.ID == _deldata).FirstOrDefault();
                    db.mas_CreditorMill.Remove(del);
                    db.SaveChanges();
                }
                DGV();
                //gloService.Announce("ลบข้อมูลเรียบร้อย", AnnounceType.Infomation);
            }
            else return;
        }
    }
}
