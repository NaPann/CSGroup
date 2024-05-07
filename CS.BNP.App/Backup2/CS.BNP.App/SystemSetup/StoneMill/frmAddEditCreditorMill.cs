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

namespace CS.BNP.App.SystemSetup.StoneMill
{
    public partial class frmAddEditCreditorMill : Form
    {
        public frmAddEditCreditorMill()
        {
            InitializeComponent();
        }
        Services.GlobalService gloService = new Services.GlobalService();
        public int iType = 0; //0 == Insert, any(ID)==Edit 
        private void ClearForm()
        {
            this.txtCreditorMillCode.Text = string.Empty; // "-- สร้างให้อัติโนมัติ --";
            this.txtCreditorMillName.Text = string.Empty; this.txtCreditorMillTel.Text = string.Empty;
            this.txtCreditorMillAddress.Text = string.Empty; this.txtCreditorMillContact.Text = string.Empty;
            this.txtCreditorMillCode.Enabled = true; this.txtCreditorMillTaxID.Text = string.Empty;
        }
        private void goSave()
        {
            bool allow = true;
            allow &= gloService.RequireColorTextbox(this.txtCreditorMillCode);
            allow &= gloService.RequireColorTextbox(this.txtCreditorMillName);
            allow &= gloService.RequireColorTextbox(this.txtCreditorMillAddress);
            allow &= gloService.RequireColorTextbox(this.txtCreditorMillContact);
            allow &= gloService.RequireColorTextbox(this.txtCreditorMillTel);

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

            //Duplicate
            if (this.iType == 0)
            {
                using (var db = new Entity.CSBNPEntities())
                {
                    var _dup = db.mas_CreditorMill.Where(w => w.CreditorMillCode == this.txtCreditorMillCode.Text.Trim()).FirstOrDefault();
                    if (_dup != null)
                    {
                        gloService.Announce("รหัสโรงโม่ซ้ำ .. กรุณาลองใหม่อีกครั้ง", AnnounceType.Warning);
                        this.txtCreditorMillCode.Select(); this.txtCreditorMillCode.SelectAll();
                        return;
                    }
                }
            }

            //Save
            if (gloService.Sure("คุณต้องการบันทึกข้อมูล ?") == DialogResult.Yes)
            {
                using (var db = new Entity.CSBNPEntities())
                {
                    Entity.mas_CreditorMill obj;
                    switch (iType)
                    {
                        case 0:
                            obj = new Entity.mas_CreditorMill();
                            obj.CreditorMillCode = this.txtCreditorMillCode.Text.Trim(); //gloService.AutoGenerate(GenerateType.Creditor);
                            obj.CreditorMillName = this.txtCreditorMillName.Text.Trim();
                            obj.CreditorMillAddress = this.txtCreditorMillAddress.Text.Trim();
                            obj.CreditorMillContact = this.txtCreditorMillContact.Text.Trim();
                            obj.CreditorMillTel = this.txtCreditorMillTel.Text.Trim();
                            obj.CreditorMillTaxID = this.txtCreditorMillTaxID.Text.Trim();
                            obj.CreatedBy = Variable.CurrentProfile.username;
                            obj.CreatedDate = DateTime.Now;
                            obj.UpdatedBy = Variable.CurrentProfile.username;
                            obj.UpdatedDate = DateTime.Now;
                            db.mas_CreditorMill.Add(obj);
                            db.SaveChanges();

                            frnViewCreditorMill frmParent = Application.OpenForms["frnViewStoneMill"] as frnViewCreditorMill;
                            frmParent.DGV();

                            // gloService.Announce("บันทึกข้อมูลเรียบร้อย", AnnounceType.Infomation);
                            break;
                        default:
                            obj = db.mas_CreditorMill.Where(w => w.ID == iType).FirstOrDefault();
                            obj.CreditorMillName = this.txtCreditorMillName.Text.Trim();
                            obj.CreditorMillAddress = this.txtCreditorMillAddress.Text.Trim();
                            obj.CreditorMillContact = this.txtCreditorMillContact.Text.Trim();
                            obj.CreditorMillTel = this.txtCreditorMillTel.Text.Trim();
                            obj.CreditorMillTaxID = this.txtCreditorMillTaxID.Text.Trim();
                            obj.UpdatedBy = Variable.CurrentProfile.username;
                            obj.UpdatedDate = DateTime.Now;
                            db.SaveChanges();
                            //gloService.Announce("แก้ไขข้อมูลเรียบร้อย", AnnounceType.Infomation);
                            this.Close();
                            break;
                    }
                }
                ClearForm();
                this.txtCreditorMillCode.Select();
            }
            else
            {
                _saveexit = 0;
                this.btnSave.Select();
                return;
            }
        }

        private byte _saveexit = 0;
        private void frmAddEditCreditorMill_Load(object sender, EventArgs e)
        {
            ClearForm();
            if (iType > 0)
            {
                using (var db = new Entity.CSBNPEntities())
                {
                    var _data = db.mas_CreditorMill.Where(w => w.ID == iType).FirstOrDefault();
                    if (_data != null)
                    {
                        this.txtCreditorMillCode.Text = _data.CreditorMillCode;
                        this.txtCreditorMillName.Text = _data.CreditorMillName;
                        this.txtCreditorMillAddress.Text = _data.CreditorMillAddress;
                        this.txtCreditorMillContact.Text = _data.CreditorMillContact;
                        this.txtCreditorMillTel.Text = _data.CreditorMillTel;
                        this.txtCreditorMillTaxID.Text = _data.CreditorMillTaxID;
                        this.txtCreditorMillCode.Enabled = false; this.txtCreditorMillName.Select(); this.txtCreditorMillName.SelectAll();
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
                this.txtCreditorMillCode.Select();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            goSave();
        }

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
    }
}
