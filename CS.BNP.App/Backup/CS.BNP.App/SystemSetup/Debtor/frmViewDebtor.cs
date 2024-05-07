using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS.BNP.App.SystemSetup.Debtor
{
    public partial class frmViewDebtor : Form
    {
        public frmViewDebtor()
        {
            InitializeComponent();
        }
        Services.GlobalService gloService = new Services.GlobalService();
        private void frmViewDebtor_Load(object sender, EventArgs e)
        {
            DGV();
        }
        public void DGV()
        {
            using (var db = new Entity.CSBNPEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                var data = db.mas_Debtor.ToList();
                this.gridControl.DataSource = data;
                this.gridControl.RefreshDataSource();
            }
        }
        private void btnAddData_Click(object sender, EventArgs e)
        {
            frmAddEditDebtor frm = new frmAddEditDebtor();
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
            frmAddEditDebtor frmEdit = new frmAddEditDebtor();
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
                    var del = db.mas_Debtor.Where(w => w.ID == _deldata).FirstOrDefault();
                    db.mas_Debtor.Remove(del);
                    db.SaveChanges();
                }
                DGV();
                gloService.Announce("ลบข้อมูลเรียบร้อย", AnnounceType.Infomation);
            }
            else return;
        }
    }
}
