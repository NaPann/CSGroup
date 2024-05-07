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

namespace CS.BNP.App.SystemSetup.Creditor
{
    public partial class frmAddEditCreditor : Form
    {
        public frmAddEditCreditor()
        {
            InitializeComponent();
        }
        Services.GlobalService gloService = new Services.GlobalService();
        public int iType = 0; //0 == Insert, any(ID)==Edit 
        private void ClearForm()
        {
            this.txtCreditorCode.Text = string.Empty; // "-- สร้างให้อัติโนมัติ --";
            this.txtCreditorName.Text = string.Empty; this.txtCreditorTel.Text = string.Empty;
            this.txtCreditorAddress.Text = string.Empty; this.txtCreditorContact.Text = string.Empty;
            this.txtCreditorCode.Enabled = true; this.txtCreditorTaxID.Text = string.Empty;
        }
        private void goSave()
        {
            bool allow = true;
            allow &= gloService.RequireColorTextbox(this.txtCreditorCode);
            allow &= gloService.RequireColorTextbox(this.txtCreditorName);
            allow &= gloService.RequireColorTextbox(this.txtCreditorAddress);
            allow &= gloService.RequireColorTextbox(this.txtCreditorContact);
            allow &= gloService.RequireColorTextbox(this.txtCreditorTel);

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
                    var _dup = db.mas_Creditor.Where(w => w.CreditorCode == this.txtCreditorCode.Text.Trim()).FirstOrDefault();
                    if (_dup != null)
                    {
                        gloService.Announce("รหัสเจ้าหนี้ซ้ำ .. กรุณาลองใหม่อีกครั้ง", AnnounceType.Warning);
                        this.txtCreditorCode.Select(); this.txtCreditorCode.SelectAll();
                        return;
                    }
                }
            }

            //Save
            if (gloService.Sure("คุณต้องการบันทึกข้อมูล ?") == DialogResult.Yes)
            {
                using (var db = new Entity.CSBNPEntities())
                {
                    Entity.mas_Creditor obj;
                    switch (iType)
                    {
                        case 0:
                            obj = new Entity.mas_Creditor();
                            obj.CreditorCode = this.txtCreditorCode.Text.Trim(); //gloService.AutoGenerate(GenerateType.Creditor);
                            obj.CreditorName = this.txtCreditorName.Text.Trim();
                            obj.CreditorAddress = this.txtCreditorAddress.Text.Trim();
                            obj.CreditorContact = this.txtCreditorContact.Text.Trim();
                            obj.CreditorTel = this.txtCreditorTel.Text.Trim();
                            obj.CreditorTaxID = this.txtCreditorTaxID.Text.Trim();
                            obj.CreatedBy = Variable.CurrentProfile.username;
                            obj.CreatedDate = DateTime.Now;
                            obj.UpdatedBy = Variable.CurrentProfile.username;
                            obj.UpdatedDate = DateTime.Now;
                            db.mas_Creditor.Add(obj);
                            db.SaveChanges();

                            frmViewCreditor frmParent = Application.OpenForms["frmViewCreditor"] as frmViewCreditor;
                            frmParent.DGV();

                           // gloService.Announce("บันทึกข้อมูลเรียบร้อย", AnnounceType.Infomation);
                            break;
                        default:
                            obj = db.mas_Creditor.Where(w => w.ID == iType).FirstOrDefault();
                            obj.CreditorName = this.txtCreditorName.Text.Trim();
                            obj.CreditorAddress = this.txtCreditorAddress.Text.Trim();
                            obj.CreditorContact = this.txtCreditorContact.Text.Trim();
                            obj.CreditorTel = this.txtCreditorTel.Text.Trim();
                            obj.CreditorTaxID = this.txtCreditorTaxID.Text.Trim();
                            obj.UpdatedBy = Variable.CurrentProfile.username;
                            obj.UpdatedDate = DateTime.Now;
                            db.SaveChanges();
                            //gloService.Announce("แก้ไขข้อมูลเรียบร้อย", AnnounceType.Infomation);
                            this.Close();
                            break;
                    }
                }
                ClearForm();
                this.txtCreditorCode.Select();
            }
            else
            {
                _saveexit = 0;
                this.btnSave.Select();
                return;
            }
        }

        private byte _saveexit = 0;
        private void frmAddEditCreditor_Load(object sender, EventArgs e)
        {
            ClearForm();
            if (iType > 0)
            {
                using (var db = new Entity.CSBNPEntities())
                {
                    var _data = db.mas_Creditor.Where(w => w.ID == iType).FirstOrDefault();
                    if (_data != null)
                    {
                        this.txtCreditorCode.Text = _data.CreditorCode;
                        this.txtCreditorName.Text = _data.CreditorName;
                        this.txtCreditorAddress.Text = _data.CreditorAddress;
                        this.txtCreditorContact.Text = _data.CreditorContact;
                        this.txtCreditorTel.Text = _data.CreditorTel;
                        this.txtCreditorTaxID.Text = _data.CreditorTaxID;
                        this.txtCreditorCode.Enabled = false; this.txtCreditorName.Select(); this.txtCreditorName.SelectAll();
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
                this.txtCreditorCode.Select();
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
