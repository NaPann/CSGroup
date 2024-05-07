using CS.BNP.App.Services;
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
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }
        Services.GlobalService gloService = new Services.GlobalService();
        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            this.txtOldPass.Select();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool allow = true;
            allow &= gloService.RequireColorTextbox(this.txtOldPass);
            allow &= gloService.RequireColorTextbox(this.txtNewPass);
            allow &= gloService.RequireColorTextbox(this.txtConfirmPass);         

            if (!allow)
            {
                this.panelWarning.Visible = true;
                return;
            }
            else
            {
                this.panelWarning.Visible = false;
            }

            if (String.Compare(this.txtNewPass.Text.Trim(), this.txtConfirmPass.Text.Trim()) != 0)
            {
                gloService.Announce("ยืนยันรหัสผ่านไม่ถูกต้อง !! กรุณาลองใหม่อีกครั้ง", AnnounceType.Warning);
                return;
            }

            using (var db = new Entity.CSBNPEntities())
            {
                var _oldPass = db.sec_EmployeeUser.Where(w => w.Password == this.txtOldPass.Text.Trim()).FirstOrDefault();
                if (_oldPass == null)
                {
                    gloService.Announce("รหัสผ่านเดิมไม่ถูกต้อง !! กรุณาลองใหม่อีกครั้ง", AnnounceType.Warning);
                    this.txtOldPass.Select(); this.txtOldPass.SelectAll();
                    return;
                }

                var data = db.sec_EmployeeUser.Where(w => w.ID == Variable.CurrentProfile.id).FirstOrDefault();
                if (data != null)
                {
                    data.Password = this.txtNewPass.Text.Trim();
                    db.SaveChanges();
                }
            }

            if (MessageBox.Show("กรุณาเข้าสู่ระบบใหม่ หลังจากที่เปลี่ยนรหัสผ่าน", "แสดงข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                frmMainMenu frmM = Application.OpenForms["frmMainMenu"] as frmMainMenu;
                Variable.chPass = 1;
                this.Close();
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
