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

namespace CS.BNP.App
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        Services.GlobalService gloService = new Services.GlobalService();
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (!gloService.RequireTextbox(this.txtUsername, "ผู้ใช้งาน")) return;
            if (!gloService.RequireTextbox(this.txtPassword, "รหัสผ่าน")) return;

            using (var db = new Entity.CSBNPEntities())
            {
                var _user = db.sec_EmployeeUser.Where(w => w.Username.CompareTo(this.txtUsername.Text.Trim()) == 0
                && w.Password.CompareTo(this.txtPassword.Text.Trim()) == 0).ToList();
                if (_user.Count() == 0)
                {
                    gloService.Announce("รหัสผู้ใช้งานหรือรหัสผ่านไม่ถูกต้อง", AnnounceType.Warning);
                    this.txtUsername.Select(); this.txtUsername.SelectAll();
                    return;
                }
                else
                {
                    //Assign
                    Services.Variable.CurrentProfile = _user.Select(s => new Models.UserProfile
                    {
                        id = s.ID,
                        firstname = s.EmployeeFirstName,
                        lastname = s.EmployeeLastName,
                        username = s.Username,
                        password = s.Password,
                        is_report = s.IsReport,
                        is_security = s.IsSecurity,
                        is_transection = s.IsTransaction,
                        is_systemsetup = s.IsSystemSetup,
                        is_admin = s.IsAdmin
                    }).FirstOrDefault();

                    frmMainMenu frm = new frmMainMenu();
                    frm.Show();
                    frm.BringToFront();
                    frm.WindowState = FormWindowState.Maximized;

                    this.Hide(); this.SendToBack();
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            ClearForm(); this.lblVersion.Text = Variable.AppVersion;
            //this.txtUsername.Text = "NaPann"; this.txtPassword.Text = "789987";
            this.txtUsername.Focus();
        }

        private void ClearForm()
        {
            this.txtUsername.Text = string.Empty;
            this.txtPassword.Text = string.Empty;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการออกจากโปรแกรม ?", "คำถาม ?",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.BtnLogin_Click(sender, e);
            }
        }
    }
}
