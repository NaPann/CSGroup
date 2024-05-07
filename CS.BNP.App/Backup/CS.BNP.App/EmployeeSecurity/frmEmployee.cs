using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace CS.BNP.App.EmployeeSecurity
{
    public partial class frmEmployee : Form
    {
        Services.GlobalService gloService = new Services.GlobalService();
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            frmAddEditEmployeeSecurity frm = new frmAddEditEmployeeSecurity();
            frm.BringToFront();
            frm.BringToFront();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            DGV();
        }
        public void DGV()
        {
            using (var db = new Entity.CSBNPEntities())
            {
                var data = db.sec_EmployeeUser.ToList();
                this.gridControl.DataSource = data;
                this.gridControl.RefreshDataSource();
            }
        }

        private void btnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //gloService.Announce(this.gridEmployeeSecurity.GetRowCellValue(this.gridEmployeeSecurity.FocusedRowHandle, gridEmployeeSecurity.Columns[0]).ToString(), AnnounceType.Error);
            frmAddEditEmployeeSecurity frmEdit = new frmAddEditEmployeeSecurity();
            frmEdit.iType = int.Parse(this.gridEmployeeSecurity.GetRowCellValue(this.gridEmployeeSecurity.FocusedRowHandle, gridEmployeeSecurity.Columns[0]).ToString());
            frmEdit.BringToFront();
            frmEdit.StartPosition = FormStartPosition.CenterParent;
            frmEdit.ShowDialog();
            DGV();
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string _strdata = this.gridEmployeeSecurity.GetRowCellValue(this.gridEmployeeSecurity.FocusedRowHandle, gridEmployeeSecurity.Columns["Username"]).ToString().Trim();
            if (_strdata == Services.Variable.CurrentProfile.username)
            {
                gloService.Announce("ไม่สามารถลบข้อมูล ผู้ใช้งาน ณ ขณะนี้ได้", AnnounceType.Warning);
                this.gridControl.Select();
                return;
            }
            else
            {
                if (gloService.Sure("คุณต้องการลบข้อมูลรายการนี้ ?") == DialogResult.Yes)
                {
                    int _deldata = int.Parse(this.gridEmployeeSecurity.GetRowCellValue(this.gridEmployeeSecurity.FocusedRowHandle, gridEmployeeSecurity.Columns[0]).ToString());
                    using (var db = new Entity.CSBNPEntities())
                    {
                        var del = db.sec_EmployeeUser.Where(w => w.ID == _deldata).FirstOrDefault();
                        db.sec_EmployeeUser.Remove(del);
                        db.SaveChanges();
                    }
                    DGV();
                    gloService.Announce("ลบข้อมูลเรียบร้อย", AnnounceType.Infomation);
                }
                else return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
