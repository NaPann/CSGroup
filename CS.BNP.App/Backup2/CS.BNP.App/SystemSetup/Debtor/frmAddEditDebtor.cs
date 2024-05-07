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

namespace CS.BNP.App.SystemSetup.Debtor
{
    public partial class frmAddEditDebtor : Form
    {
        public frmAddEditDebtor()
        {
            InitializeComponent();
        }
        Services.GlobalService gloService = new Services.GlobalService();
        public int iType = 0; //0 == Insert, any(ID)==Edit 
        private void ClearForm()
        {
            this.txtDebtorCode.Text = string.Empty; //"-- สร้างให้อัติโนมัติ --";
            this.txtDebtorName.Text = string.Empty; this.txtDebtorTel.Text = string.Empty;
            this.txtDebtorAddress.Text = string.Empty; this.txtDebtorContact.Text = string.Empty;
            this.txtDebtorCode.Enabled = true; this.txtDebtorTaxID.Text = string.Empty;
        }
        private void goSave()
        {
            bool allow = true;
            allow &= gloService.RequireColorTextbox(this.txtDebtorCode);
            allow &= gloService.RequireColorTextbox(this.txtDebtorName);
            allow &= gloService.RequireColorTextbox(this.txtDebtorAddress);
            allow &= gloService.RequireColorTextbox(this.txtDebtorContact);
            allow &= gloService.RequireColorTextbox(this.txtDebtorTel);
            allow &= gloService.RequireColorTextbox(this.txtDebtorTaxID);

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
                    var _dup = db.mas_Debtor.Where(w => w.DebtorCode == this.txtDebtorCode.Text.Trim()).FirstOrDefault();
                    if (_dup != null)
                    {
                        gloService.Announce("รหัสลูกหนี้ซ้ำ .. กรุณาลองใหม่อีกครั้ง", AnnounceType.Warning);
                        this.txtDebtorCode.Select(); this.txtDebtorCode.SelectAll();
                        return;
                    }
                }
            }

            //Save
            if (gloService.Sure("คุณต้องการบันทึกข้อมูล ?") == DialogResult.Yes)
            {
                using (var db = new Entity.CSBNPEntities())
                {
                    Entity.mas_Debtor obj;
                    switch (iType)
                    {
                        case 0:
                            obj = new Entity.mas_Debtor();
                            obj.DebtorCode = this.txtDebtorCode.Text.Trim(); //gloService.AutoGenerate(GenerateType.Debtor);
                            obj.DebtorName = this.txtDebtorName.Text.Trim();
                            obj.DebtorAddress = this.txtDebtorAddress.Text.Trim();
                            obj.DebtorContact = this.txtDebtorContact.Text.Trim();
                            obj.DebtorTel = this.txtDebtorTel.Text.Trim();
                            obj.DebtorTaxID = this.txtDebtorTaxID.Text.Trim();
                            obj.CreatedBy = Variable.CurrentProfile.username;
                            obj.CreatedDate = DateTime.Now;
                            obj.UpdatedBy = Variable.CurrentProfile.username;
                            obj.UpdatedDate = DateTime.Now;
                            db.mas_Debtor.Add(obj);
                            db.SaveChanges();

                            frmViewDebtor frmParent = Application.OpenForms["frmViewDebtor"] as frmViewDebtor;
                            frmParent.DGV();

                           // gloService.Announce("บันทึกข้อมูลเรียบร้อย", AnnounceType.Infomation);
                            break;
                        default:
                            obj = db.mas_Debtor.Where(w => w.ID == iType).FirstOrDefault();
                            obj.DebtorName = this.txtDebtorName.Text.Trim();
                            obj.DebtorAddress = this.txtDebtorAddress.Text.Trim();
                            obj.DebtorContact = this.txtDebtorContact.Text.Trim();
                            obj.DebtorTel = this.txtDebtorTel.Text.Trim();
                            obj.DebtorTaxID = this.txtDebtorTaxID.Text.Trim();
                            obj.UpdatedBy = Variable.CurrentProfile.username;
                            obj.UpdatedDate = DateTime.Now;
                            db.SaveChanges();
                            //gloService.Announce("แก้ไขข้อมูลเรียบร้อย", AnnounceType.Infomation);
                            this.Close();
                            break;
                    }
                }
                ClearForm();
                this.txtDebtorName.Select();
            }
            else
            {
                _saveexit = 0;
                this.btnSave.Select();
                return;
            }
        }

        private byte _saveexit = 0;
        private void frmAddEditDebtor_Load(object sender, EventArgs e)
        {
            ClearForm();
            if (iType > 0)
            {
                using (var db = new Entity.CSBNPEntities())
                {
                    db.Configuration.LazyLoadingEnabled = false;
                    var _data = db.mas_Debtor.Where(w => w.ID == iType).FirstOrDefault();
                    if (_data != null)
                    {
                        this.txtDebtorCode.Text = _data.DebtorCode;
                        this.txtDebtorName.Text = _data.DebtorName;
                        this.txtDebtorAddress.Text = _data.DebtorAddress;
                        this.txtDebtorContact.Text = _data.DebtorContact;
                        this.txtDebtorTel.Text = _data.DebtorTel;
                        this.txtDebtorTaxID.Text = _data.DebtorTaxID;
                        this.txtDebtorCode.Enabled = false; this.txtDebtorName.Select(); this.txtDebtorName.SelectAll();
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
                this.txtDebtorCode.Select();
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
