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
    public partial class frmAddEditEmployeeSecurity : Form
    {
        public frmAddEditEmployeeSecurity()
        {
            InitializeComponent();
        }
        Services.GlobalService gloService = new Services.GlobalService();
        public int iType = 0; //0 == Insert, any(ID)==Edit 
        private void btnSave_Click(object sender, EventArgs e)
        {
            goSave();
        }

        private void goSave()
        {
            bool allow = true;
            allow &= gloService.RequireColorTextbox(this.txtEmpCode);
            allow &= gloService.RequireColorTextbox(this.txtEmpFirstName);
            allow &= gloService.RequireColorTextbox(this.txtEmpLastName);
            allow &= gloService.RequireColorTextbox(this.txtUsername);
            if (this.iType == 0)
                allow &= gloService.RequireColorTextbox(this.txtPassword);

            if (this.chkListFunction.CheckedItems.Count == 0)
            {
                this.lblChkList.BackColor = Color.LightCoral;
                allow &= false;
            }
            else
            {
                this.lblChkList.BackColor = Color.White;
                allow &= true;
            }

            if (!allow)
            {
                this.panelWarning.Visible = true;
                _saveexit = 0;
                return;
            }
            else
            {
                this.panelWarning.Visible = false;
                _saveexit = 1;
            }

            if (this.txtUsername.Text.Trim().Length < 4)
            {
                gloService.Announce("รหัสผู้ใช้งานอย่างน้อย 4 ตัวอักษร", AnnounceType.Warning);
                this.txtUsername.Select(); this.txtUsername.SelectAll();
                return;
            }

            if (this.iType > 0 && !string.IsNullOrWhiteSpace(this.txtPassword.Text.Trim()))
            {
                if (this.txtPassword.Text.Trim().Length < 4)
                {
                    gloService.Announce("รหัสผ่านอย่างน้อย 4 ตัวอักษร", AnnounceType.Warning);
                    this.txtPassword.Select(); this.txtPassword.SelectAll();
                    return;
                }
            }
            else if (this.iType == 0)
            {
                if (this.txtPassword.Text.Trim().Length < 4)
                {
                    gloService.Announce("รหัสผ่านอย่างน้อย 4 ตัวอักษร", AnnounceType.Warning);
                    this.txtPassword.Select(); this.txtPassword.SelectAll();
                    return;
                }
            }

            //Duplicate
            if (this.iType == 0)
            {
                using (var db = new Entity.CSBNPEntities())
                {
                    var _dup = db.sec_EmployeeUser.Where(w => w.Username == this.txtUsername.Text.Trim()).FirstOrDefault();
                    if (_dup != null)
                    {
                        gloService.Announce("รหัสผู้ใช้งานซ้ำ .. กรุณาลองใหม่อีกครั้ง", AnnounceType.Warning);
                        this.txtUsername.Select(); this.txtUsername.SelectAll();
                        return;
                    }
                }
            }

            //Save
            if (gloService.Sure("คุณต้องการบันทึกข้อมูล ?") == DialogResult.Yes)
            {
                var db = new Entity.CSBNPEntities();
                Entity.sec_EmployeeUser obj;
                switch (iType)
                {
                    case 0:
                        obj = new Entity.sec_EmployeeUser();
                        obj.EmployeeCode = this.txtEmpCode.Text.Trim();
                        obj.EmployeeFirstName = this.txtEmpFirstName.Text.Trim();
                        obj.EmployeeLastName = this.txtEmpLastName.Text.Trim();
                        obj.Username = this.txtUsername.Text.Trim();
                        obj.Password = this.txtPassword.Text.Trim();
                        obj.IsSecurity = this.chkListFunction.GetItemChecked(0);
                        obj.IsSystemSetup = this.chkListFunction.GetItemChecked(1);
                        obj.IsTransaction = this.chkListFunction.GetItemChecked(2);
                        obj.IsReport = this.chkListFunction.GetItemChecked(3);
                        obj.IsAdmin = this.chkListFunction.GetItemChecked(4);
                        obj.CreatedBy = Variable.CurrentProfile.username;
                        obj.CreatedDate = DateTime.Now;
                        obj.UpdatedBy = Variable.CurrentProfile.username;
                        obj.UpdatedDate = DateTime.Now;

                        obj.NeedToApprove = this.chkIsApprove.Checked;
                        obj.NeedToApproveBy = this.cbApp.Properties.GetCheckedItems().ToString();

                        db.sec_EmployeeUser.Add(obj);
                        db.SaveChanges();

                        //Assign
                        db = new Entity.CSBNPEntities();
                        var _user = db.sec_EmployeeUser.Where(w => w.ID == Variable.CurrentProfile.id).ToList();
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

                        var mainForm = Application.OpenForms["frmMainMenu"] as frmMainMenu;
                        mainForm.SetAuthorization();


                        frmEmployee frmParent = Application.OpenForms["frmEmployee"] as frmEmployee;
                        frmParent.DGV();

                       // gloService.Announce("บันทึกข้อมูลเรียบร้อย", AnnounceType.Infomation);
                        break;
                    default:
                        obj = db.sec_EmployeeUser.Where(w => w.ID == iType).FirstOrDefault();
                        obj.EmployeeCode = this.txtEmpCode.Text.Trim();
                        obj.EmployeeFirstName = this.txtEmpFirstName.Text.Trim();
                        obj.EmployeeLastName = this.txtEmpLastName.Text.Trim();
                        obj.Username = this.txtUsername.Text.Trim();
                        if (!string.IsNullOrWhiteSpace(this.txtPassword.Text.Trim()))
                            obj.Password = this.txtPassword.Text.Trim();
                        obj.IsSecurity = this.chkListFunction.GetItemChecked(0);
                        obj.IsSystemSetup = this.chkListFunction.GetItemChecked(1);
                        obj.IsTransaction = this.chkListFunction.GetItemChecked(2);
                        obj.IsReport = this.chkListFunction.GetItemChecked(3);
                        obj.IsAdmin = this.chkListFunction.GetItemChecked(4);
                        obj.UpdatedBy = Variable.CurrentProfile.username;
                        obj.UpdatedDate = DateTime.Now;

                        obj.NeedToApprove = this.chkIsApprove.Checked;
                        obj.NeedToApproveBy = this.cbApp.Properties.GetCheckedItems().ToString();

						db.SaveChanges();
                        //gloService.Announce("แก้ไขข้อมูลเรียบร้อย", AnnounceType.Infomation);

                        //Assign
                        db = new Entity.CSBNPEntities();
                        var _userEx = db.sec_EmployeeUser.Where(w => w.ID == Variable.CurrentProfile.id).ToList();
                        Services.Variable.CurrentProfile = _userEx.Select(s => new Models.UserProfile
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

                        var mainFormEx = Application.OpenForms["frmMainMenu"] as frmMainMenu;
                        mainFormEx.SetAuthorization();

                        this.Close();
                        break;
                }

                ClearForm();
                this.txtEmpCode.Select();
            }
            else
            {
                this.btnSave.Select();
                return;
            }
        }

        private void frmAddEditEmployeeSecurity_Load(object sender, EventArgs e)
        {
            ClearForm();
            if (iType > 0)
            {              
                using (var db = new Entity.CSBNPEntities())
                {
                    var _data = db.sec_EmployeeUser.Where(w => w.ID == iType).FirstOrDefault();
                    if (_data != null)
                    {
                        this.txtEmpCode.Text = _data.EmployeeCode; this.txtEmpFirstName.Text = _data.EmployeeFirstName; this.txtEmpLastName.Text = _data.EmployeeLastName;
                        this.txtUsername.Text = _data.Username;
                        this.chkListFunction.SetItemChecked(0, _data.IsSecurity);
                        this.chkListFunction.SetItemChecked(1, _data.IsSystemSetup); this.chkListFunction.SetItemChecked(2, _data.IsTransaction); this.chkListFunction.SetItemChecked(3, _data.IsReport);
                        this.chkListFunction.SetItemChecked(4, _data.IsAdmin);

                        this.cbApp.SetEditValue(_data.NeedToApproveBy); this.chkIsApprove.Checked = _data.NeedToApprove;

                        this.txtEmpCode.Enabled = false; this.txtEmpFirstName.Select(); this.txtEmpFirstName.SelectAll();
                    }
                    else
                    {
                        gloService.Announce("ไม่สามารถค้นหาข้อมูลได้ .. โปรดตรวจสอบ", AnnounceType.Infomation);
                        this.Close();
                        return;
                    }
                }
            }
            else
                this.txtEmpCode.Select();
        }

        private void ClearForm()
        {
            this.txtEmpCode.Text = string.Empty; this.txtEmpFirstName.Text = string.Empty; this.txtEmpLastName.Text = string.Empty;
            this.txtUsername.Text = string.Empty; this.txtPassword.Text = string.Empty; this.chkListFunction.ClearSelected(); this.chkIsApprove.Checked = false; this.cbApp.Enabled = false;
            for (int i = 0; i < this.chkListFunction.Items.Count; i++)
                chkListFunction.SetItemCheckState(i, CheckState.Unchecked);
            this.txtEmpCode.Enabled = true; BindingControl();
        }
        private void BindingControl()
        {
            using (var db = new Entity.CSBNPEntities())
            {
                var data = db.sec_EmployeeUser.Where(w=>w.ID != iType).OrderBy(o => o.ID).Select(s => new
                {
                    val = s.Username,
                    txt = s.EmployeeFirstName + " " + s.EmployeeLastName
                }).ToList();
                //data.Insert(0, new { val = "", txt = "-- เลือกผู้ที่สามารถ Approve --" });
                //this.cbApprover.DataSource = data;
                //this.cbApprover.DisplayMember = "txt";
                //this.cbApprover.ValueMember = "val";

                foreach (var item in data)
                {
                    this.cbApp.Properties.Items
                        .Add(item.val, item.txt);
                }
				this.cbApp.Properties.DisplayMember = "txt";
				this.cbApp.Properties.ValueMember = "val";
			}
        }
        private byte _saveexit = 0;
        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            _saveexit = 1;
            goSave();
            if (_saveexit == 1)
                this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkIsApprove_CheckedChanged(object sender, EventArgs e)
        {
            this.cbApp.Enabled = this.chkIsApprove.Checked;
        }
    }
}
